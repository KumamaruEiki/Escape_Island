using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpGage : MonoBehaviour
{
    public WolfManager wolfManager;

    public Image HpGreen;   //�΂�HP�o�[

    private bool decreaseFlag = false;  //���炷���ǂ����̃t���O

    private float gdecrease;    //�΂̌��炷��
    private int maxhp;          //���݂̂�MAX�̗�
    private int nexthp;         //���̗̑�(MAX�̗�-1)


    // Start is called before the first frame update
    void Start()
    {
        //�V�[�����Ƃ�MAX�̗͂����߂�
        if (SceneManager.GetActiveScene().name == "BattleScene3")
            maxhp = Touch.B3cnt;                    //��
        else if (SceneManager.GetActiveScene().name == "InosisiBattle")
            maxhp = Isirusi.Iclearnum;              //�C�m�V�V
        else if (SceneManager.GetActiveScene().name == "SnakeBattle")
            maxhp = Ssirusi.Sclearnum;              //�w�r
        
        nexthp = maxhp - 1;                     //���̗̑�(MAXHP-1)
        gdecrease = HpGreen.fillAmount / maxhp; //�΂̌��炷��(1/MAXHP)
    }

    // Update is called once per frame
    void Update()
    {
        //�̗͂����炷
        if (Touch.B3cnt == nexthp || Isirusi.Iclearnum == nexthp || Ssirusi.Sclearnum == nexthp)  //�c��̃N���b�N�񐔂Ǝ��̗̑͂��ꏏ�ɂȂ�����
        {
            if (decreaseFlag == false)//��x�������炷
            {
                HpGreen.fillAmount -= gdecrease;    //�΂̗̑͂����炷
                Debug.Log("g");

                maxhp = nexthp;     //���̗̑͂��������̂�����MAX�̗͂ɂȂ�
                nexthp = maxhp - 1; //���̗̑�


                decreaseFlag = true;
            }
        }
        else
            decreaseFlag = false;
    }
}
