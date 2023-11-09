using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direction : MonoBehaviour
{
    public GameObject target;//�����_���ȏꏊ
    public GameObject[] layerobj;
    Renderer deerSprite;
    public static bool obstacles;

    // Start is called before the first frame update
    void Start()
    {
        obstacles = false;
    
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacles")&&deerSprite.sortingOrder==1)
        {        
            obstacles = true;
        }
        if (collision.CompareTag("wall"))
        {
            for (int i = 0; i < 2; i++)
            {
                deerSprite = layerobj[i].GetComponent<Renderer>();
                deerSprite.sortingOrder = 3;
            }
        }
    }
    //private void o (Collider2D collision)
    //{
        
    //}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacles"))
        {
            obstacles = false;
        }
        if (collision.CompareTag("wall"))
        {
            
                deerSprite.sortingOrder = 1;
            
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
