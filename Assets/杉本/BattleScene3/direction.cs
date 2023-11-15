using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    public GameObject target;//�����_���ȏꏊ
    public static bool obstacles;

    // Start is called before the first frame update
    void Start()
    {
        obstacles = false;
    
    }

    //��Q���ƐG��Ă�����
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Obstacles"))
        {        
            obstacles = true;
        }
        
    }

    //���ꂽ��
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Obstacles"))
        {
            obstacles = false;
        }
        

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
