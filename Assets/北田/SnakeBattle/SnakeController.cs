using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;

    private Transform snake1;
    private bool moving = true;

    GameObject clickedGameObject;

    // Start is called before the first frame update
    void Start()
    {
        snake1 = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        // �i�|�C���g�j�}�C�i�X�������邱�Ƃŋt�����Ɉړ�����B
        transform.Translate(transform.right * Time.deltaTime * 3 * num);

        if (pos.x > -2)
        {
            num = -1;
        }

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hitSprite == true)
            {
                clickedGameObject = hitSprite.transform.gameObject;
                if (clickedGameObject.tag == "snake")
                {
                    Destroy(clickedGameObject);
                }
            }
        }
    }

    //�ڐG����
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //�ԂȂ�e���|�[�g
        if (collision.gameObject.tag == "left")
        {
            snake1.localPosition = new Vector2(11, 2);
        }
    }
}
