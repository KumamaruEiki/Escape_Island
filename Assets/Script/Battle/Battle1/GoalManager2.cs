using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager2 : MonoBehaviour
{
    public string sceneName;//�ǂݍ��ރV�[����

    public int plasnum;//10�ɑ������ݒ�
    public Text Goaltext;//�N���A���e�L�X�g
    public GameObject ClearUI;

    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        TouchsignB.goalnum = plasnum;
    }

    // Update is called once per frame
    void Update()
    {
        //�ڕW���\��
        Goaltext.text = TouchsignB.goalnum.ToString("0");

        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if(TouchsignB.goalnum == 0)
        {
            StartC.onclick = false;
            ClearUI.SetActive(true);
            Invoke("Clear",3.0f);
        }
    }

    //�N���A�����Ƃ��̊֐�
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.woodFlg = true;
    }
}
