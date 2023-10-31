using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfManager : MonoBehaviour
{
    public GameObject Wolf;//�I�I�J�~ 
    public float movespeed;//�ړ����x

    public int topPos;//������̈ړ�����
    public int bottomPos;//�������̈ړ�����
    public int leftPos;//�������̈ړ�����
    public int rightPos;//�E�����̈ړ�����

    Vector3 movePosition;//�ړI�n�ݒ�

    float Attacktime;//�U�����s���܂ł̎��Ԑݒ�

    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition();//�I�u�W�F�N�g�̖ړI�n��ݒ�

        Attacktime = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (movePosition == Wolf.transform.position)  //�I�u�W�F�N�g���ړI�n�ɓ��B����ƁA
        {
            movePosition = moveRandomPosition();  //�ړI�n���Đݒ�
        }
        //�I�u�W�F�N�g��, �ړI�n�Ɉړ�����
        this.Wolf.transform.position = Vector3.MoveTowards(Wolf.transform.position, movePosition, movespeed * Time.deltaTime);


    }

    private Vector3 moveRandomPosition()  
    {
        // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
        Vector3 randomPosi = new Vector3(Random.Range(leftPos, rightPos), Random.Range(bottomPos,topPos ), 5);

        //�ړI�n��Ԃ�
        return randomPosi;
    }
}
