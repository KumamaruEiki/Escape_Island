using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartC : MonoBehaviour
{
    public static bool onclick;//�N���b�N���ꂽ���ǂ������ʕϐ�
    public static bool starttf;

    public GameObject StartBotton;//�X�^�[�g�{�^��
    public GameObject StartTimeText;//�X�^�[�g�^�C���e�L�X�g


    // Start is called before the first frame update
    void Start()
    {
        StartTimeText.SetActive(false);
        starttf = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Load()
    {
        Invoke("Click", 3.0f);
        starttf = true;

        Debug.Log("aaa");
        StartTimeText.SetActive(true);//�J�n���ԕ\��
              
        StartBotton.SetActive(false);//�{�^����\��

    }

    public void Click()
    {
        onclick = true;
 
    }
}