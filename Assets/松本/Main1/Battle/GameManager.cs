using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //�������Ԓǉ�
    public GameObject timeText;//���ԃe�L�X�g
    CountDown timeCnt; //CountDown�X�N���v�g�������Ă��邽�߂̕ϐ�

    // Start is called before the first frame update
    void Start()
    {
        //�������Ԃ�ǉ�
        //CountDown�R���|�[�l���g�擾
        timeCnt = GetComponent<CountDown>();
    }

    // Update is called once per frame
    void Update()
    {
        float time = timeCnt.CountDownTime;
        timeText.GetComponent<Text>().text = time.ToString();
    }
}
