using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoalManager : MonoBehaviour
{
    public static bool BattleClearFlg1;//�o�g���P���N���A���ꂽ���ǂ����̃t���O
    public string sceneName;//�ǂݍ��ރV�[����

    public int plasnum;//10�ɑ������ݒ�
    public Text Goaltext;//�N���A���e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        BattleClearFlg1 = false;
        TouchsignB.goalnum += plasnum;
    }

    // Update is called once per frame
    void Update()
    {
        //�ڕW���\��
        Goaltext.text = TouchsignB.goalnum.ToString("0");

        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if(TouchsignB.goalnum == 0)
        {
            Clear();
        }
    }

    //�N���A�����Ƃ��̊֐�
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        BattleClearFlg1 = true;
    }
}
