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

    public int WolfHP;//�I�I�J�~��HP�ϐ�
    public float activetime;//���邵���A�N�e�B�u�ɂȂ�܂ł̎���
    public string sceneName;//�Ăяo���V�[����

    public static int wolfnum;//�|�����I�I�J�~�𐔂���p
    // Start is called before the first frame update
    void Start()
    {
        movePosition = moveRandomPosition();//�I�u�W�F�N�g�̖ړI�n��ݒ�
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[�����n�܂�����
        if(StartC.onclick)
        {
            keikatime += Time.deltaTime;
            //�E�B�[�N�|�C���g�̍ĕ\��
            if (!WeakPoint.pointFlg)
            {
                
                if (keikatime > activetime)
                {
                    weakPoint.SetActive(true);//�ĕ\��
                    WeakPoint.pointFlg = true;
                    keikatime = 0.0f;
                    anim.SetBool("Attack", false);//�A�j���[�V������walk�ɖ߂�
                }
            }
            if(keikatime>Attacktime-1.2f)
            {
                anim.SetBool("Attack", true);
            }
            if (keikatime>Attacktime)
            {
                hpManager.Attack();

                Debug.Log("attack!");
                //�o�ߎ��Ԃ�0�ɖ߂�
                keikatime = 0.0f;
                anim.SetBool("Attack", false);
                //�v���C���[��HP��0�ɂȂ�����Q�[���I�[�o�[���Ăяo��
                if (PHP == 0)
                {
                    GameOver();
                }
            }
        }
        

        if (movePosition == Wolf.transform.position)  //�I�u�W�F�N�g���ړI�n�ɓ��B����ƁA
        {
            movePosition = moveRandomPosition();  //�ړI�n���Đݒ�
        }
        //�I�u�W�F�N�g��, �ړI�n�Ɉړ�����
        this.Wolf.transform.position = Vector3.MoveTowards(Wolf.transform.position, movePosition, movespeed * Time.deltaTime);

        if (WolfHP == 0)
        {
            wolfnum++;
            //HP��0�ɂȂ�����E���t������
            Wolf.SetActive(false);

        }

        
    }

    private Vector3 moveRandomPosition()  
    {
        // �ړI�n�𐶐��Ax��y�̃|�W�V�����������_���ɒl���擾 
        Vector3 randomPosi = new Vector3(Random.Range(leftPos, rightPos), Random.Range(bottomPos,topPos ), 5);

        //�ړI�n��Ԃ�
        return randomPosi;
    }


    void GameOver()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void  Damage()
    {
        WolfHP--;
    }
}
