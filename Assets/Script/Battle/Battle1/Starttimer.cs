using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starttimer : MonoBehaviour
{
    public GameObject StartTimeText;//�X�^�[�g�^�C���e�L�X�g

    public Text Timetext;//�J�n���ԃe�L�X�g
    float startlimit=3.0f;

    // Start is called before the first frame update
    void Start()
    {
        Timetext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!StartC.starttf)
        {
            return;
        }
        startlimit -= Time.deltaTime;
        Timetext.text = startlimit.ToString("0");


        if(startlimit<=0)
        {
            Timetext.text = "�X�^�[�g�I";
            StartTimeText.SetActive(false);
            
        }
    }
}
