using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartC : MonoBehaviour
{
    public static bool onclick;//�N���b�N���ꂽ���ǂ������ʕϐ�

    public GameObject StartBotton;//�X�^�[�g�{�^��
    public GameObject StartTimeText;//�X�^�[�g�^�C���e�L�X�g

    int time=3;//�J�n�܂ł̎���
    public Text timetext;//�J�n�܂ł̎��ԕ\��

    int gametime = 3;
    int times;

    // Start is called before the first frame update
    void Start()
    {
        StartTimeText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(onclick)
        {
            times += (int)Time.deltaTime;
            time = gametime - times;
            timetext.text = time.ToString();
        }
     
    }

    public void Load()
    {
        Invoke("Click", 3.0f);
     
        for(int i=0;i<=3;i++)
        {
            StartTimeText.SetActive(true);
        }
        
        StartBotton.SetActive(false);//�{�^����\��

    }

    public void Click()
    {
        onclick = true;
 
    }
}
