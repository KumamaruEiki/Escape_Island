using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class messegeManager : MonoBehaviour
{
    public GameObject yumimessege;
    public GameObject craftmessege;
    public GameObject handlemessege;
    public GameObject craftmessege2;
    public GameObject clearmessege;
    public GameObject colectmessege;

    // Start is called before the first frame update
    void Start()
    {
        //�ŏ��̃��b�Z�[�W
        if(!GameManager.Battele1Flg)
        {
            yumimessege.SetActive(true);
        }
        //�o�g���P�N���A��
        if(GameManager.Battele1Flg&&!GameManager.BowFlg)
        {
            craftmessege.SetActive(true);
        }
        //�|��쐬��
        if(!GameManager.Battele3Flg&&!GameManager.woodFlg&&GameManager.BowFlg)
        {
            handlemessege.SetActive(true);
        }
        //�n���h���ޗ����W��
        if(GameManager.Battele3Flg&&GameManager.woodFlg)
        {
            craftmessege2.SetActive(true);
        }
        //�S�ޗ����W��
        if(GameManager.HandleFlg && GameManager.GasFlg && GameManager.puroperaFlg)
        {
            clearmessege.SetActive(true);
        }
        if(GameManager.HandleFlg)
        {
            colectmessege.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("hide", 2.0f);
        
    }
    void hide()
    {
        yumimessege.SetActive(false);
        craftmessege.SetActive(false);
        handlemessege.SetActive(false);
        craftmessege2.SetActive(false);
        clearmessege.SetActive(false);
        colectmessege.SetActive(false);
    }
}
