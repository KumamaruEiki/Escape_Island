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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacles"))
        {
            Touch.Click = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Obstacles"))
        {
            Touch.Click = true;
        }
    }
    // Update is called once per frame
    void Update()
    {               
        if(Touch.Click==true)
        {
            speed = 0.02f;
        }
        else
        {
            speed = 0.01f;
        }

        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed);
    }
}