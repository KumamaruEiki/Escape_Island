using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tonkachi : MonoBehaviour
{
    public GameObject obj;
    public float speed = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    


    void Update()
    {
        //�~�j�Q�[�����n�܂�ƈړ��J�n
        if (CraftMain.MCrearFlag == false)
        {
            obj.transform.position += new Vector3(speed, 0, 1) * Time.deltaTime;
        }
        else
            Destroy(obj);
    }
}
