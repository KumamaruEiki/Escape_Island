using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleButton : MonoBehaviour
{
    public GameObject Handlebutton;
    public GameObject gettext;
    public GameObject misstext;

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.HandleFlg)
        {
            Handlebutton.SetActive(false);
        }
        gettext.SetActive(false);
        misstext.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UI()
    {
        if(GameManager.Battele3Flg)
        {
            gettext.SetActive(true);
            GameManager.HandleFlg = true;
            Handlebutton.SetActive(false);
            Invoke("hide",2.0f);
        }
        else
        {
            misstext.SetActive(true);
            Invoke("hide", 2.0f);
        }
    }

    void hide()
    {
        gettext.SetActive(false);
        misstext.SetActive(false);
    }
}
