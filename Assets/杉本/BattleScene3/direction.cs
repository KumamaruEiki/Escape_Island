using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    public GameObject target;//�����_���ȏꏊ

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < target.transform.position.x)             //�����̈ʒu�������_���̈ړ��ꏊ���E���Ȃ�
        {

            transform.localScale = new Vector2(-1, 1);  //�摜���]
        }
        else if (transform.position.x == target.transform.position.x)        //�ړ��ꏊ�ɂ�����
        {
            transform.localScale = transform.localScale;//�摜�͂��̂܂�
        }
        else                                                                //�����Ȃ�
        {
            transform.localScale = new Vector2(1, 1);   //���̉摜
        }
    }
}
