using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpGage : MonoBehaviour
{
    public Image HpGreen;   //�΂�HP�o�[

    private bool decreaseFlag = false;  //���炷���ǂ����̃t���O

    private float gdecrease =0;    //�΂̌��炷��
    private int maxhp=0;          //���݂̂�MAX�̗�
    private int nexthp=0;         //���̗̑�(MAX�̗�-1)


    // Start is called before the first frame update
    void Start()
    {
        gdecrease = 0;
        maxhp = -5;
        nexthp = -5;
        Invoke("Initialization", 1.0f);//�Q�[�W�̏�������x�点��
    }

    void Initialization()
    {
        //�V�[�����Ƃ�MAX�̗͂����߂�
        if (SceneManager.GetActiveScene().name == "BattleScene3")
        {
            Debug.Log(SceneManager.GetActiveScene().name);
            maxhp = Touch.B3cnt;
        }
        else
            Touch.B3cnt = 10;
        //��
        if (SceneManager.GetActiveScene().name == "InosisiBattle")
            maxhp = Isirusi.Iclearnum;
        else
            Isirusi.Iclearnum = 10;//�C�m�V�V
        if (SceneManager.GetActiveScene().name == "SnakeBattle")
            maxhp = Ssirusi.Sclearnum;              //�w�r
        else
            Ssirusi.Sclearnum = 10;

        nexthp = maxhp - 1;                     //���̗̑�(MAXHP-1)
        gdecrease = HpGreen.fillAmount / maxhp; //�΂̌��炷��(1/MAXHP)
    }
    // Update is called once per frame
    void Update()
    {
        //�̗͂����炷
        if (Touch.B3cnt == nexthp || Isirusi.Iclearnum == nexthp || Ssirusi.Sclearnum == nexthp)  //�c��̃N���b�N�񐔂Ǝ��̗̑͂��ꏏ�ɂȂ�����
        {
            Debug.Log("b");
            if (decreaseFlag == false)//��x�������炷
            {

                HpGreen.fillAmount -= gdecrease;    //�΂̗̑͂����炷
                Debug.Log("a");
                maxhp = nexthp;     //���̗̑͂��������̂�����MAX�̗͂ɂȂ�
                nexthp = maxhp - 1; //���̗̑�
                Debug.Log(nexthp);

                decreaseFlag = true;
            }
        }
        else
            decreaseFlag = false;
    }
}
