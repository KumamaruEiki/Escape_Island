using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Craftgage : MonoBehaviour
{
    public Image HpGreen;   //�΂�HP�o�[

    private bool decreaseFlag = false;  //���炷���ǂ����̃t���O

    private float gdecrease = 0;    //�΂̌��炷��
    private int maxhp = 0;          //���݂̂�MAX�̗�
    private int nexthp = 0;         //���̗̑�(MAX�̗�-1)

    // Start is called before the first frame update
    void Start()
    {
        gdecrease = 0;
        maxhp = -5;
        nexthp = -5;
        //HpGreen.fillAmount = 0.0f;
        Invoke("Initialization", 1.0f);//�Q�[�W�̏�������x�点��

    }

    void Initialization()
    {
        maxhp = CraftMain.MCrear;

        nexthp = maxhp - 1;                     //���̗̑�(MAXHP-1)
        gdecrease = 1.0f / maxhp; //�΂̌��炷��(1/MAXHP)

    }

    // Update is called once per frame
    void Update()
    {
        if (CraftMain.MCrear == nexthp)  //�c��̃N���b�N�񐔂Ǝ��̗̑͂��ꏏ�ɂȂ�����
        {
            Debug.Log("c");
            if (decreaseFlag == false)//��x�������炷
            {

                HpGreen.fillAmount += gdecrease;    //�΂̗̑͂����炷
                Debug.Log("d");
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
