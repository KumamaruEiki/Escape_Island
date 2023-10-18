using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �ړ�������
    bool isMoving; 

    Vector2 input;
    Transform player;

    //�ړ��X�s�[�h
    [SerializeField] float moveSpeed;

    //�ق��̃I�u�W�F�N�g���Ȃ����̔���
    bool other_obj;

    // Start is called before the first frame update
    void Start()
    {
        player= GameObject.Find ("Hero").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // �ړ������Ɠ��͂��󂯕t���Ȃ�
        if (!isMoving)
        {
            //����̏�����
            other_obj = false;

            // �L�[�{�[�h�̓��͏���input�Ɋi�[
            input.x = Input.GetAxisRaw("Horizontal")*2.05f; // ������
            input.y = Input.GetAxisRaw("Vertical")*2.05f;  // �c����

            // ���͂���������
            if (input != Vector2.zero)
            {
                // ���͂�����������ړI�n�ɂ���
                Vector2 targetPos = transform.position;
                targetPos += input;

                Vector2 target_v = new Vector2(targetPos.x, targetPos.y);
                Vector2 Hero_pos = new Vector2(player.position.x, player.position.y);

                //Ray�̍쐬
                Ray2D ray = new Ray2D(Hero_pos, target_v);
                //Raycast�̍쐬
                RaycastHit2D hit= Physics2D.Raycast(ray.origin, ray.direction, 2.0f);

                //Ray�����������������true�ɂ���
                if (hit)
                {
                    other_obj = true;
                }
               
                //�ق��̃R���C�_�[���Ȃ��Ƃ��ړ����J�n����
                if (!other_obj)
                StartCoroutine(Move(targetPos));

                
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
