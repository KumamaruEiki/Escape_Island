using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Battle3Clear : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool BattleClearFlg3;//�o�g��3���N���A���ꂽ���ǂ����̃t���O
    public string sceneName;//�ǂݍ��ރV�[����

    public int plasnum;//10�ɑ������ݒ�
    public Text Goaltext;//�N���A���e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        Goaltext = GetComponent<Text>();
        BattleClearFlg3 = false;
        Touch.B3cnt += plasnum;
    }

    // Update is called once per frame
    void Update()
    {
        //�ڕW���\��
        Goaltext.text = Touch.B3cnt.ToString("0");

        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if (Touch.B3cnt == 0)
        {
            Clear();
        }
    }

    //�N���A�����Ƃ��̊֐�
    void Clear()
    {
        SceneManager.LoadScene(sceneName);
        BattleClearFlg3 = true;
    }
}
