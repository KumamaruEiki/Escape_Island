using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemymove : MonoBehaviour
{
    public Transform target;
    public static Vector2 HeroPosition;//��l���̈ʒu�ۑ��p�ϐ�

    public static bool isMoving;// �ړ�������

    bool other_obj;//�ق��̃I�u�W�F�N�g���Ȃ����̔���
    public LayerMask WallLayer;//WallLayer��ݒ�

    Vector2 input;

    //�ړ��X�s�[�h
    [SerializeField] float moveSpeed;

    public GameObject boar;
    //private Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Battele4_1Flg)
        {
            boar.SetActive(false);
        }
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����
        // �ړ������Ɠ��͂��󂯕t���Ȃ�
        if (!isMoving&&BattleScene.movestop==false)
        {
            //����̏�����
            other_obj = false;


            Vector2 pos = transform.position;

            //Vector2 direction;
            input = target.position - transform.position;
            Debug.Log(target.position + "taget");
            Debug.Log(transform.position + "enemy");
            Debug.Log(input + "kyori");


            if(target.position==transform.position)
            {
                transform.localScale = transform.localScale;//�摜�͂��̂܂�
                return;
            }
            if (input.x >= input.y && input.x > 0) 
            {
                Debug.Log("x�݂�");
                pos.x += 2.0f;
                pos.y += 0.0f;
                transform.localScale = new Vector2(-0.3f, 0.3f);  //�摜���]
            }
            else if (input.x < input.y && input.x < 0)
            {
                Debug.Log("x�Ђ���");
                pos.x -= 2.0f;
                pos.y += 0.0f;
                transform.localScale = new Vector2(0.3f, 0.3f);  //�摜���]
            }
            else if (input.x <= input.y && input.y > 0)
            {
                Debug.Log("y����");
                pos.x += 0.0f;
                pos.y += 2.0f;
            }
            else if (input.x > input.y && input.y < 0)
            {
                Debug.Log("y����");
                pos.x += 0.0f;
                pos.y -= 2.0f;
            }


            // �L�[�{�[�h�̓��͏���input�Ɋi�[
            //input.x = Input.GetAxisRaw("Horizontal") * 2.0f; // ������
            //input.y = Input.GetAxisRaw("Vertical") * 2.0f;  // �c����
            //�v���C���[�������̃|�W�V�����������ƕ���

            // ���͂���������
            if (input != Vector2.zero)
            {
                // ���͂�����������ړI�n�ɂ���

                //Vector2 targetPos = transform.position;
                //targetPos += pos;


                //���̃R���C�_�[���Ȃ����̔���
                if (input.y < 0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position - (transform.up * 2.0f), WallLayer);//������
                else if (input.y > 0)
                    other_obj = Physics2D.Linecast(transform.position, transform.position + (transform.up * 2.0f), WallLayer);//�����
                else if (input.x < 0)
                    other_obj = Physics2D.Linecast(transform.position - (transform.right * 2.0f), transform.position, WallLayer);//������
                else if (input.x > 0)
                    other_obj = Physics2D.Linecast(transform.position + (transform.right * 2.0f), transform.position, WallLayer);//�E����


                //�ق��̃R���C�_�[���Ȃ��Ƃ��ړ����J�n����
                if (!other_obj)
                    StartCoroutine(Move(pos));


            }
        }
        HeroPosition = this.transform.position;//���݂̈ʒu��ۑ�����

        

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
    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerController.isMoving = true;
        Invoke("encount", 2.0f);
    }
    void encount()
    {
        SceneManager.LoadScene("InosisiBattle");
        ChangeScene1.batnum = 4;
        PlayerController.isMoving = false;
    }
}
