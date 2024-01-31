using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    private Vector2 pos;
    public int num = -1;
    public float speed=4;
    public float updown=0;
    float rad;
    private Transform snake1;
    //private bool moving = true;

    int radpos;//�Đ����ꏊ
    public GameObject clickedGameObject;//���邵
    public GameObject yaa;//��

    //SE
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    bool kirikae = false;

    [SerializeField] GameObject hitPrefab;//�G�t�F�N�g
    // Start is called before the first frame update
    void Start()
    {
        snake1 = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //���邵���N���b�N�����Ƃ��̓���
        if (Ssirusi.sign == true)
        {
            Instantiate(hitPrefab, transform.position, Quaternion.identity);
            audioSource.PlayOneShot(se);
            Invoke("hyouzi", 3.0f);
            Ssirusi.sign = false;
            yaa.SetActive(true);
            Invoke("hihyouzi", 1.0f);
        }

        //�֍s�̕�����
        rad += 0.1f;
        if(rad>360)
        {
            rad = 0;
        }

        //���݈ʒu�ۑ�
        pos = transform.position;

        //������E�Ɏ֍s���Ȃ���ړ�����B
        if(Ssirusi.Sclearnum > 3)
        {
            transform.Translate(transform.right * Time.deltaTime * speed * num);//������
            transform.Translate(transform.up * Time.deltaTime * speed * updown);//�c����
        }
        else
        {
            num = 1;
            transform.Translate(transform.right * Time.deltaTime * speed * num);//������
            transform.Translate(transform.up * Time.deltaTime * speed * updown);//�c����
        }

        if (Ssirusi.Sclearnum <= 3)
            transform.localScale = new Vector2(-0.3f, 0.3f);  //�摜���]

        //if (pos.x > -2)
        //{
        //    num = -1;
        //}
        //if (pos.x < 0 && kirikae == false)
        //{
        //    num = Random.Range(-1, 1);
        //    kirikae = true;
        //}
        updown = Mathf.Sin(rad);
        if(pos.x<-12)
        {
            radpos = Random.Range(1, 5);
            //������E�Ƀe���|�[�g
            if (radpos == 1)
                    snake1.localPosition = new Vector2(11, 2);
            if (radpos == 2)
                    snake1.localPosition = new Vector2(11, 0);
            if (radpos == 3)
                    snake1.localPosition = new Vector2(11, -2);
            if (radpos == 4)
                    snake1.localPosition = new Vector2(11, -3);
            kirikae = false;
        }
        if(pos.x>13)
        {
            radpos = Random.Range(1, 5);
            //�E���獶�Ƀe���|�[�g
            if (radpos == 1)
                snake1.localPosition = new Vector2(-11, 2);
            if (radpos == 2)
                snake1.localPosition = new Vector2(-11, 0);
            if (radpos == 3)
                snake1.localPosition = new Vector2(-11, -2);
            if (radpos == 4)
                snake1.localPosition = new Vector2(-11, -3);
        }
        
        if(pos.y>5)
        {
            //��ɍs���߂���ƍ��Ƀe���|�[�g
            radpos = Random.Range(1, 5);
            if (radpos == 1)
                snake1.localPosition = new Vector2(11, 2);
            if (radpos == 2)
                snake1.localPosition = new Vector2(11, 0);
            if (radpos == 3)
                snake1.localPosition = new Vector2(11, -2);
            if (radpos == 4)
                snake1.localPosition = new Vector2(11, -3);
            kirikae = false;
        }
        if(pos.y<-7)
        {
            //���ɍs���߂���ƍ��Ƀe���|�[�g
            radpos = Random.Range(1, 5);
            if (radpos == 1)
                snake1.localPosition = new Vector2(11, 2);
            if (radpos == 2)
                snake1.localPosition = new Vector2(11, 0);
            if (radpos == 3)
                snake1.localPosition = new Vector2(11, -2);
            if (radpos == 4)
                snake1.localPosition = new Vector2(11, -3);
            updown = Random.Range(1, 2);
            kirikae = false;
        }

        speed += 0.001f;
        if(Ssirusi.Sclearnum==6)
        {
            speed = 7f;
        }
        //if (Input.GetMouseButtonDown(0))
        //{

        //    clickedGameObject = null;

        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        //    if (hitSprite == true)
        //    {
        //        clickedGameObject = hitSprite.transform.gameObject;
        //        if (clickedGameObject.tag == "snake")
        //        {
        //            Destroy(clickedGameObject);
        //        }
        //    }
        //}
    }

    //�ڐG����
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    radpos = Random.Range(1, 5);
    //    //�ԂȂ�e���|�[�g
    //    if (collision.gameObject.tag == "left")
    //    {
    //        if (radpos == 1)
    //            snake1.localPosition = new Vector2(11, 2);
    //        if (radpos == 2)
    //            snake1.localPosition = new Vector2(11, 0);
    //        if (radpos == 3)
    //            snake1.localPosition = new Vector2(11, -2);
    //        if (radpos == 4)
    //            snake1.localPosition = new Vector2(11, -3);
    //    }
    //}
    void hyouzi()
    {
        clickedGameObject.SetActive(true);
        
    }
    void hihyouzi()
    {
        yaa.SetActive(false);
    }
}
