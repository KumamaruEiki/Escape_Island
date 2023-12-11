using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    StartC startc;//StartC

    //�J�E���g�_�E���ϐ�
    public float countdown;

    //�e�L�X�g�ϐ�
    public Text timeText;

    //�ǂݍ��ރV�[����
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        startc = GetComponent<StartC>();
        if(GameManager.Hellmode)
        {
            countdown -= 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (StartC.onclick)
        {
            //�J�E���g�����炷����
            countdown -= Time.deltaTime;

            //��ʂɕ\������
            timeText.text = countdown.ToString("f1") + "�b";

            if (countdown <= 0)
            {
                //�J�E���g��0�ȉ��ɂȂ�����Load���Ăяo���ăV�[���ڍs
                Load();
            }
        }
    }

    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }
}
