using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public int goalnum;//�N���A�ɕK�v�Ȍ�
    public string sceneName;//�ǂݍ��ރV�[����

    public Text Goaltext;//�N���A���e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ڕW���\��
        Goaltext.text = goalnum.ToString("0");

        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if(goalnum == 0)
        {
            Clear();
        }
    }

    //�N���A�����Ƃ��̊֐�
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
    }
}
