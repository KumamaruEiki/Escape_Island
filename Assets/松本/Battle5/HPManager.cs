using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{
    public Text HPtext;//HP�̎c��\���e�L�X�g

    // Start is called before the first frame update
    void Start()
    {
        HPtext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //���݂̂̂���HP�\��
        HPtext.text = WolfManager.PHP.ToString("0");
    }
}
