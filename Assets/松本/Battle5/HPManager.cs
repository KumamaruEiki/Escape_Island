using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPManager : MonoBehaviour
{
    public Text HPtext;//HP�̎c��\���e�L�X�g

    public WolfManager wolfManager;

    public string sceneName;
    private AudioSource audioSource;
    [SerializeField] private AudioClip se;

    // Start is called before the first frame update
    void Start()
    {
        HPtext = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //���݂̂̂���HP�\��
        HPtext.text = wolfManager.PHP.ToString("0");
        if(wolfManager.PHP<0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void Attack()
    {
        wolfManager.PHP--;
        audioSource.PlayOneShot(se);
    }
}
