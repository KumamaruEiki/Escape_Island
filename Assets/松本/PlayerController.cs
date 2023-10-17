using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isMoving; // �ړ�������

    Vector2 input;

    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ړ������Ɠ��͂��󂯕t���Ȃ�
        if (!isMoving)
        {
            // �L�[�{�[�h�̓��͏���input�Ɋi�[
            input.x = Input.GetAxisRaw("Horizontal")*2.05f; // ������
            input.y = Input.GetAxisRaw("Vertical")*2.05f;  // �c����

            // ���͂���������
            if (input != Vector2.zero)
            {
                // ���͂�����������ړI�n�ɂ���
                Vector2 targetPos = transform.position;
                targetPos += input;
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
