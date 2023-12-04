
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject deer;
    public Transform target;
    public static bool isMoving;// �ړ�������

    bool other_obj;//�ق��̃I�u�W�F�N�g���Ȃ����̔���
    public LayerMask WallLayer;//WallLayer��ݒ�

    Vector2 input;

    //�ړ��X�s�[�h
    [SerializeField] float moveSpeed;

    private Animator anim = null;

    Vector3 RightUP = new Vector2(6.5f, 3.5f);
    Vector3 RightDown = new Vector2(6.5f, -4.5f);
    Vector3 LeftUP = new Vector2(-9.5f, 3.5f);
    Vector3 LeftDown = new Vector2(-9.5f, -4.5f);

    //�㉺���E�̈ړ�����������p
    bool UP=false;
    bool DOWN = false;
    bool RIGHT = false;
    bool LEFT = false;


    private AudioSource audioSource;
    [SerializeField] private AudioClip se;
    //�����_���ړ��p�ϐ�
    int radvec;
    //bool kadoueFlg;
    //bool kadositaFlg;

    // Start is called before the first frame update
    void Start()
    {
      if(GameManager.Battele3Flg)
        {
            deer.SetActive(false);
        }
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����
        // �ړ������Ɠ��͂��󂯕t���Ȃ�
        if (!isMoving)
        {
            //����̏�����
            other_obj = false;
            Vector2 pos = transform.position;

            //Vector2 direction;
            input = target.position - transform.position;
            //Debug.Log(target.position + "taget");
            //Debug.Log(transform.position + "enemy");
            //Debug.Log(input + "kyori");


            //if (transform.position == RightUP || transform.position == LeftUP)
            //{
            //    kadoueFlg = true;
            //}
            //if (transform.position == RightDown || transform.position == LeftDown)
            //{
            //    kadositaFlg = true;
            //}

            //��l�����瓦����ړ�
            if ((-2<input.x&&input.x<2)||(-2<input.y&&input.y<2))
            {
                Debug.Log("nigeru");
                if (target.position == transform.position)
                {
                    //transform.localScale = transform.localScale;//�摜�͂��̂܂�
                    return;
                }
                else if (input.x >= input.y && input.x > 0)
                {
                    Debug.Log("x�݂�");
                    pos.x -= 2.0f;
                    pos.y += 0.0f;
                    LEFT = true;
                    // transform.localScale = new Vector2(-0.3f, 0.3f);  //�摜���]
                }
                else if (input.x < input.y && input.x < 0)
                {
                    Debug.Log("x�Ђ���");
                    pos.x += 2.0f;
                    pos.y += 0.0f;
                    RIGHT = true;
                    //transform.localScale = new Vector2(0.3f, 0.3f);  //�摜���]
                }
                else if (input.x <= input.y && input.y > 0)
                {
                    Debug.Log("y����");
                    pos.x += 0.0f;
                    pos.y -= 2.0f;
                    DOWN = true;
                }
                else if (input.x > input.y && input.y < 0)
                {
                    Debug.Log("y����");
                    pos.x += 0.0f;
                    pos.y += 2.0f;
                    UP = true;
                }
            }
            //���m�͈͊O�̎��̃����_���ړ�
            else
            {
                radvec = Random.Range(0, 4);
                if (radvec==0)
                {
                    Debug.Log("x��");
                    pos.x -= 2.0f;
                    pos.y += 0.0f;
                    LEFT = true;
                    // transform.localScale = new Vector2(-0.3f, 0.3f);  //�摜���]
                }
                else if (radvec==1)
                {
                    Debug.Log("x�݂�");
                    pos.x += 2.0f;
                    pos.y += 0.0f;
                    RIGHT = true;
                    //transform.localScale = new Vector2(0.3f, 0.3f);  //�摜���]
                }
                else if (radvec==2)
                {
                    Debug.Log("y����");
                    pos.x += 0.0f;
                    pos.y -= 2.0f;
                    DOWN = true;
                }
                else if (radvec==3)
                {
                    Debug.Log("y����");
                    pos.x += 0.0f;
                    pos.y += 2.0f;
                    UP = true;
                }
            }
            //else if()
            //{
            //    if(transform.position.x>0&&transform.position.y>0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y += 2.0f;
            //    }
            //    else if(transform.position.x < 0 && transform.position.y > 0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y += 2.0f;
            //    }
            //    else if(transform.position.x < 0 && transform.position.y < 0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y -= 2.0f;
            //    }
            //    else if(transform.position.x > 0 && transform.position.y < 0)
            //    {
            //        pos.x += 0.0f;
            //        pos.y -= 2.0f;
            //    }
            //}
            // �L�[�{�[�h�̓��͏���input�Ɋi�[
            // input.x = Input.GetAxisRaw("Horizontal") * 2.0f; // ������
            //  input.y = Input.GetAxisRaw("Vertical") * 2.0f;  // �c����

            // ���͂���������
            if (input != Vector2.zero)
            {
                // ���͂�����������ړI�n�ɂ���


                //���̃R���C�_�[���Ȃ����̔���
                if (UP)
                {
                    other_obj = Physics2D.Linecast(transform.position, transform.position + (transform.up * 2.0f), WallLayer);//�����
                    UP = false;
                }  
                else if (DOWN)
                {
                    other_obj = Physics2D.Linecast(transform.position, transform.position - (transform.up * 2.0f), WallLayer);//������
                    DOWN = false;
                }
                else if (RIGHT)
                {
                    other_obj = Physics2D.Linecast(transform.position + (transform.right * 2.0f), transform.position, WallLayer);//�E����
                    RIGHT = false;
                }
                else if (LEFT)
                {
                    other_obj = Physics2D.Linecast(transform.position - (transform.right * 2.0f), transform.position, WallLayer);//������
                    LEFT = false;
                }

                //||kadoueFlg==true||kadositaFlg==true

                //�ق��̃R���C�_�[���Ȃ��Ƃ��ړ����J�n����
                if (!other_obj)
                    StartCoroutine(Move(pos));
                


            }
        }

        //�A�j���[�V��������
        //float horizontalKey = Input.GetAxis("Horizontal");
        //float verticalKey = Input.GetAxis("Vertical");

        //if (isMoving)
        //{
        //    if (input.x > 0)
        //    {
        //        anim.SetBool("Vecright", true);
        //        anim.SetBool("Vecleft", false);
        //        anim.SetBool("Vecup", false);
        //    }
        //    else if (input.x < 0)
        //    {

        //        anim.SetBool("Vecleft", true);
        //        anim.SetBool("Vecright", false);
        //        anim.SetBool("Vecup", false);
        //    }
        //    else if (input.y > 0)
        //    {
        //        anim.SetBool("Vecup", true);
        //        anim.SetBool("Vecright", false);
        //        anim.SetBool("Vecleft", false);
        //    }
        //    else if (input.y < 0)
        //    {

        //        anim.SetBool("Vecup", false);
        //        anim.SetBool("Vecright", false);
        //        anim.SetBool("Vecleft", false);

        //    }
        //}

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
        //kadositaFlg = false;
        //kadoueFlg = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(se);
        PlayerController.stop = true;
        Invoke("encount", 2.0f);

    }
    void encount()
    {
        SceneManager.LoadScene("BattleScene3");
        ChangeScene1.posnum = 0;
        ChangeScene1.batnum = 3;
        PlayerController.stop = false;
    }
}
