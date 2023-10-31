using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static Vector2 HeroPosition;//��l���̈ʒu�ۑ��p�ϐ�
    public static bool isMoving;// �ړ�������

    bool other_obj;//�ق��̃I�u�W�F�N�g���Ȃ����̔���
    public LayerMask WallLayer;//WallLayer��ݒ�

    Vector2 input;

    //�ړ��X�s�[�h
    [SerializeField] float moveSpeed;

    private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        if(GoalManager.BattleClearFlg1)
        transform.position = HeroPosition;//�ۑ������ʒu���J�n���ɌĂяo��
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����
        // �ړ������Ɠ��͂��󂯕t���Ȃ�
        if (!isMoving)
        {
            //����̏�����
            other_obj = false;

            // �L�[�{�[�h�̓��͏���input�Ɋi�[
            input.x = Input.GetAxisRaw("Horizontal")*2.0f; // ������
            input.y = Input.GetAxisRaw("Vertical")*2.0f;  // �c����

            // ���͂���������
            if (input != Vector2.zero)
            {
                // ���͂�����������ړI�n�ɂ���
                Vector2 targetPos = transform.position;
                targetPos += input;


                //���̃R���C�_�[���Ȃ����̔���
                if(input.y<0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position - (transform.up * 2.0f), WallLayer);//������
                else if(input.y>0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position + (transform.up * 2.0f), WallLayer);//�����
                else if (input.x < 0)
                    other_obj = Physics2D.Linecast(transform.position - (transform.right * 2.0f), transform.position,WallLayer);//������
                else if (input.x > 0)
                    other_obj = Physics2D.Linecast(transform.position + (transform.right * 2.0f), transform.position, WallLayer);//�E����


                //�ق��̃R���C�_�[���Ȃ��Ƃ��ړ����J�n����
                if (!other_obj)
                StartCoroutine(Move(targetPos));

                
            }
        }
        HeroPosition = this.transform.position;//���݂̈ʒu��ۑ�����

        //�A�j���[�V��������
        //float horizontalKey = Input.GetAxis("Horizontal");
        //float verticalKey = Input.GetAxis("Vertical");

        if (isMoving)
        {
            if (input.x > 0)
            {
                anim.SetBool("Vecright", true);
                anim.SetBool("Vecleft", false);
                anim.SetBool("Vecup", false);
            }
            else if (input.x < 0)
            {
                
                anim.SetBool("Vecleft", true);
                anim.SetBool("Vecright", false);
                anim.SetBool("Vecup", false);
            }
            else if (input.y > 0)
            {
                anim.SetBool("Vecup", true);
                anim.SetBool("Vecright", false);
                anim.SetBool("Vecleft", false);
            }
            else if(input.y<0)
            {
                
                    anim.SetBool("Vecup", false);
                    anim.SetBool("Vecright", false);
                    anim.SetBool("Vecleft", false);
                
            }
        }

    }

    //�@�R���[�`�����g���ď��X�ɖړI�n�ɋ߂Â���
    IEnumerator Move(Vector3 targetPos)
    {
        // �ړ����͓��͂��󂯕t���Ȃ�
        isMoving = true;

        // targetpos�Ƃ̍�������Ȃ�J��Ԃ�:�ړI�n�ɒH�蒅���܂ŌJ��Ԃ�
        while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            // targetPos�ɋ߂Â���
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            // ���X�ɋ߂Â��邽��
            yield return null;
        }

        // �ړ�����������������ړI�n�ɓ���������
        transform.position = targetPos;
        isMoving = false;
    }

    
}
