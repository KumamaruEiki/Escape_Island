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
        SceneManager.LoadScene(sceneName);
        posnum = mnum;
        batnum = bnum;
    }
}
