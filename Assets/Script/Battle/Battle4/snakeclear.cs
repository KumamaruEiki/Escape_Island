using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class snakeclear : MonoBehaviour
{
    public string sceneName;
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
        Goaltext.text = Ssirusi.Sclearnum.ToString("0");

        //goalnum��0�ɂȂ�����N���A�֐����Ăяo��
        if (Ssirusi.Sclearnum == 0)
        {
            Clear();
        }
    }
     void Clear()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.Battele4_2Flg = true;
    }
}
