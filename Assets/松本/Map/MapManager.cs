using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public string sceneName;//�ǂݍ��ރV�[����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey||Input.GetMouseButton(0)|| Input.GetMouseButton(1)|| Input.GetMouseButton(2))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
