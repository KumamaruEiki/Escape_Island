using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossSceneHp : MonoBehaviour
{
    public WolfManager wolfManager;

    public Image HpGreen;   //�΂�HP�o�[
    private bool decreaseFlag = false;  //���炷���ǂ����̃t���O
    private float gdecrease;    //�΂̌��炷��

    //�v���C���[
    private int maxhp;          //���݂̂�MAX�̗�
    private int nexthp;         //���̗̑�(MAX�̗�-1)

   
    // Start is called before the first frame update
    void Start()
    {
        maxhp = wolfManager.PHP;
        nexthp = maxhp - 1;                     //���̗̑�(MAXHP-1)
        gdecrease = HpGreen.fillAmount / maxhp; //�΂̌��炷��(1/MAXHP)
    }

    // Update is called once per frame
    void Update()
    {
        ////�v���C���[�ȊO�@�̗͂����炷
        //if (WolfHPmanager.WolfHP1 == w1nexthp || WolfHPmanager.WolfHP2 == w2nexthp || WolfHPmanager.WolfHP3 == w3nexthp)  //�c��̃N���b�N�񐔂Ǝ��̗̑͂��ꏏ�ɂȂ�����
        //{
        //    if (decreaseFlag == false)//��x�������炷
        //    {
        //        HpGreen.fillAmount -= gdecrease;    //�΂̗̑͂����炷
        //        Debug.Log("g");

        //        maxhp = nexthp;     //���̗̑͂��������̂�����MAX�̗͂ɂȂ�
        //        nexthp = maxhp - 1; //���̗̑�


        //        decreaseFlag = true;
        //    }
        //}
        //else
        //    decreaseFlag = false;


        //�{�X�V�[��PlayerHP�@�U�����d�Ȃ����ꍇ���܂߂ā@�̗͂����炷����       
        if (decreaseFlag == false && wolfManager.PHP == nexthp)         //1�_���[�W
        {
            HpGreen.fillAmount -= gdecrease;    //�΂̗̑͂����炷
            Debug.Log(HpGreen.fillAmount);

            maxhp = nexthp;     //���̗̑͂��������̂�����MAX�̗͂ɂȂ�
            nexthp = maxhp - 1; //���̗̑�

            decreaseFlag = true;
        }
        else if (decreaseFlag == false && wolfManager.PHP == nexthp - 1)//2�_���[�W
        {
            HpGreen.fillAmount -= gdecrease * 2;    //�΂̗̑͂����炷
            Debug.Log(HpGreen.fillAmount);

            nexthp -= 1;
            maxhp = nexthp;     //���̗̑͂��������̂�����MAX�̗͂ɂȂ�
            nexthp = maxhp - 1; //���̗̑�

            decreaseFlag = true;
        }
        else if (decreaseFlag == false && wolfManager.PHP == nexthp - 2)//3�_���[�W
        {
            HpGreen.fillAmount -= gdecrease * 3;    //�΂̗̑͂����炷
            Debug.Log(HpGreen.fillAmount);

            nexthp -= 2;
            maxhp = nexthp;     //���̗̑͂��������̂�����MAX�̗͂ɂȂ�
            nexthp = maxhp - 1; //���̗̑�

            decreaseFlag = true;
        }
        decreaseFlag = false;
    }
}

