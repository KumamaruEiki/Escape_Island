using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float CountDownTime;//�J�E���g�_�E���ϐ�
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //�o�ߎ��Ԃ������Ă���
        CountDownTime -= Time.deltaTime;

        //0�b�ȉ��ɂȂ�����Œ�
        if(CountDownTime<=0.0f)
        {
            CountDownTime = 0.0f;
        }
    }
}
