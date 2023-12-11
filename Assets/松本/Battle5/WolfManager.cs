using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WolfManager : MonoBehaviour
{
    private Animator anim = null;

    public HPManager hpManager;

    public GameObject Wolf;//�I�I�J�~ 
    public GameObject weakPoint;//���邵
    public float movespeed;//�ړ����x

    public int topPos;//������̈ړ�����
    public int bottomPos;//�������̈ړ�����
    public int leftPos;//�������̈ړ�����
    public int rightPos;//�E�����̈ړ�����
    Vector3 movePosition;//�ړI�n�ݒ�

    public float keikatime;//�o�ߎ��ԗp�ϐ�
    public float Attacktime;//�U�����s���܂ł̎��Ԑݒ�
    public int PHP=10;//�v���C���[��HP�ϐ�

    //public int WolfHP1;//�I�I�J�~1��HP�ϐ�
    //public int WolfHP2;//�I�I�J�~2��HP�ϐ�
    //public int WolfHP3;//�I�I�J�~3��HP�ϐ�
    public float activetime;//���邵���A�N�e�B�u�ɂȂ�܂ł̎���
    public string sceneName;//�Ăяo���V�[����

    public static int wolfnum;//�|�����I�I�J�~�𐔂���p
    public WolfHPmanager wolfManager;
    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition();//�I�u�W�F�N�g�̖ړI�n��ݒ�
        anim = GetComponent<Animator>();
        if(GameManager.Hellmode)
        {
            PHP = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[�����n�܂�����
        if(StartC.onclick)
        {
            keikatime += Time.deltaTime;
            //�E�B�[�N�|�C���g�̍ĕ\��
            if (!weakPoint.activeInHierarchy)
            {
                //�E�B�[�N�|�C���g�������Ă��ԂɂȂ�����walk�ɂ���
                anim.SetBool("Attack", false);
                //�A�N�e�B�u�^�C���o�߂�����ĕ\��
                if (keikatime > activetime)
                {
                    Debug.Log("hyouzi");
                    weakPoint.SetActive(true);//�ĕ\��
                    keikatime = 0.0f;
                    anim.SetBool("Attack", false);//�A�j���[�V������walk�ɖ߂�
                }
            }
            else
            {
                //�U�����[�V�����J�n
                if (keikatime > Attacktime - 1.0f)
                {
                    anim.SetBool("Attack", true);
                }
                //�I�I�J�~�̍U��
                if (keikatime > Attacktime)
                {
                    hpManager.Attack();
                    //wolfManager.damageSE();

                    //�o�ߎ��Ԃ�0�ɖ߂�
                    keikatime = 0.0f;
                    anim.SetBool("Attack", false);

                }
            }
            
        }
        
        if(wolfnum==1)
        {
            movespeed = 7;
        }
        if(wolfnum==2)
        {
            movespeed = 8;
        }

        if (movePosition == Wolf.transform.position)  //�I�u�W�F�N�g���ړI�n�ɓ��B����ƁA
        {
            movePosition = moveRandomPosition();  //�ړI�n���Đݒ�
        }
        //�I�u�W�F�N�g��, �ړI�n�Ɉړ�����
        this.Wolf.transform.position = Vector3.MoveTowards(Wolf.transform.position, movePosition, movespeed * Time.deltaTime);
        //���E���]�������肷��A�j���[�V����
        if(movePosition.x>Wolf.transform.position.x)
        {
            //�E����
            transform.localScale = new Vector3(-1, 1, 1);
            //anim.SetBool("Attack", false);
        }
        else
        {
            //������
            transform.localScale = new Vector3(1, 1, 1);
            //anim.SetBool("Attack", false);
        }
        //if (WolfHP == 0)
        //{
        //    wolfnum++;
        //    //HP��0�ɂȂ�����E���t������
        //    Wolf.SetActive(false);

        //}

        
    }

    private Vector3 moveRandomPosition()  
    {
        // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
        Vector3 randomPosi = new Vector3(Random.Range(leftPos, rightPos), Random.Range(bottomPos,topPos ), 0);

        //�ړI�n��Ԃ�
        return randomPosi;
    }


    void GameOver()
    {
        SceneManager.LoadScene(sceneName);
    }

    //public void  Damage1()
    //{
    //    WolfHP1--;
    //}
}
