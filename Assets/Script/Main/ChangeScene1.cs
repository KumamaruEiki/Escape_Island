using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    public string sceneName;//�ǂݍ��ރV�[����
    public int mnum;
    public int bnum;
    public static int posnum;//�Ăяo���ꏊ����p
    public static int batnum;//���g���C�p

    Color fadeColor = Color.black;
    float fadespeed=1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Load()
    {
        Initiate.Fade(sceneName, fadeColor, fadespeed);
        posnum = mnum;
        batnum = bnum;
    }
}
