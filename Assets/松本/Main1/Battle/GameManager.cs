using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�������Ԓǉ�
    public GameObject timeText;//���ԃe�L�X�g
  
    public StartC Starting;//StartC�X�N���v�g�������Ă��邽�߂̕ϐ�

    public float CountDownTime;//�J�E���g�_�E���ϐ�


    // Start is called before the first frame update
    void Start()
    { 
        //StartC�R���|�[�l���g�擾
        Starting = GetComponent<StartC>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Starting.gameplay)
        {
              
            //�o�ߎ��Ԃ������Ă���
            CountDownTime -= Time.deltaTime;

            //0�b�ȉ��ɂȂ�����Œ�
            if (CountDownTime <= 0.0f)
            {
                CountDownTime = 0.0f;
            }

            //�^�C���X�V
            timeText.GetComponent<Text>().text = CountDownTime.ToString();
        }

    }
}
