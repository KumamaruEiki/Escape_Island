using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movedeer : MonoBehaviour
{
    public GameObject target;//�����_���ȏꏊ
    public static float speed = 0.01f;//�ړ����x
    public static Vector2 transformpos;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {            
        
    }
    private void FixedUpdate()
    {
        //�N���b�N���ꂽ��X�s�[�h�A�b�v
        if (Touch.click == true)
        {
            speed = 0.2f;
        }
        //�ʏ�̃X�s�[�h
        else
        {
            speed = 0.1f;
        }

        //movepoint��ǂ�������
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed);
    }
}