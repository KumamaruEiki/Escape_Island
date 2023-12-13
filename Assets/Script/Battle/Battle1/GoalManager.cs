using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public string sceneName;//�ǂݍ��ރV�[����

    public int plasnum;//�N���A��
    public Text Goaltext;//�N���A���e�L�X�g
    public GameObject ClearUI;

    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        TouchsignB.goalnum += plasnum;
        if(GameManager.Hellmode)
        {
            TouchsignB.goalnum += 10;
        }
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ڕW���\��
        Goaltext.text = TouchsignB.goalnum.ToString("0");

        if(TouchsignB.animFlg)
        {
            anim.SetBool("hit", true);
            TouchsignB.animFlg = false;
            Invoke("ani", 1.0f);
        }
        
        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if(TouchsignB.goalnum == 0)
        {
            TouchsignB.goalnum = 0;
            StartC.onclick = false;
            ClearUI.SetActive(true);
            Invoke("Clear", 3.0f);
        }
    }

    //�N���A�����Ƃ��̊֐�
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele1Flg = true;
    }
    void ani()
    {
        anim.SetBool("hit", false);
    }
}
