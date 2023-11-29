using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScene : MonoBehaviour
{
    public string sceneName;//�ǂݍ��ރV�[����
    //public static bool movestop=false;

    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(se);
        Invoke("battle", 2.0f);
        PlayerController.stop = true;
    }

    void battle()
    {

        SceneManager.LoadScene(sceneName);
        ChangeScene1.batnum = 5;
        ChangeScene1.posnum = 0;
        PlayerController.stop = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
