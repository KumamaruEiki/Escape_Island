using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float CountDownTime;//�J�E���g�_�E���ϐ�
    public Text TextCountDown;//�\���e�L�X�g�ϐ�

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = 10.0f;//�J�E���g�_�E���̒l��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        //�J�E���g�_�E���𐮌`���ĕ\��
        TextCountDown.text = string.Format("��������: {0:00.00}", CountDownTime);
        //�o�ߎ��Ԃ������Ă���
        CountDownTime -= Time.deltaTime;

        //0�b�ȉ��ɂȂ�����Œ�
        if(CountDownTime<=0.0f)
        {
            CountDownTime = 0.0f;
        }
    }
}
