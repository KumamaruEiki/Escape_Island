using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deerhp : MonoBehaviour
{
    public Image HpGreen;   //�΂�HP�o�[
    //public Image HpRed;     //�Ԃ�HP�o�[

    //private Battle3Clear deer;
    private bool decreaseFlag = false;  //���炷���ǂ����̃t���O

    float gdecrease;    //�΂̌��炷��
   // float rdecrease;    //�Ԃ̌��炷��
    //float rdecreasedown = 0.01f;
    int maxhp;          //����MAX�̗�
    int nexthp;         //���̗̑�(MAX�̗�-1)
    // Start is called before the first frame update
    void Start()
    {
        maxhp = Touch.B3cnt;                    //�ŏ��̗̑�
        nexthp = maxhp - 1;                     //���̗̑�
        gdecrease = HpGreen.fillAmount / maxhp; //�΂̌��炷��(1/MAXHP)
        //rdecrease = HpRed.fillAmount / maxhp; //�Ԃ̌��炷��(1/MAXHP)
    }

    void RDecrease()
    {
        
    }


    // Update is called once per frame
    void Update()
    {         
        if (Touch.B3cnt == nexthp)  //�c��̃N���b�N�񐔂Ǝ��̗̑͂��ꏏ�ɂȂ�����
        {
            if (decreaseFlag == false)//��x�������炷
            {
                HpGreen.fillAmount -= gdecrease;    //�΂̗̑͂����炷
                Debug.Log("g");

                //for (; HpRed.fillAmount <= HpRed.fillAmount - rdecrease;)//�Ԃ̗̑͂����X�Ɍ��炷
                //{
                //    Debug.Log("r");
                //    HpRed.fillAmount -= 0.01f;
                //}
           
                maxhp = nexthp;     //���̗̑͂��������̂�����MAX�̗͂ɂȂ�
                nexthp = maxhp - 1; //���̗̑�

                decreaseFlag = true;
            }              
        }
        else
            decreaseFlag = false;
    }
}
