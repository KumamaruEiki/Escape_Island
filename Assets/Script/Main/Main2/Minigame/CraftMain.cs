using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftMain : MonoBehaviour
{
    static public int MCrear = 10;
    static public bool MCrearFlag = false;
    public GameObject craftCanvas;//�N���t�g�L�����o�X
    public GameObject MinigameImg;//�N���t�g���
    public GameObject clear;//�N���A�摜

    public GameObject Bgettext;
    public GameObject Hgettext;
    // Start is called before the first frame update
    void Start()
    {
        MCrear = 10;
        MCrearFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(MCrear==0)
        {
            MCrearFlag = true;
            clear.SetActive(true);
            Invoke("quit", 2.0f);
        }
    }

    void quit()
    {
        craftCanvas.SetActive(false);
        MinigameImg.SetActive(false);
        clear.SetActive(false);
        if(BowButton.bowflg)
        {
            Bgettext.SetActive(true);
            
        }
        if(HandleButton.handleflg)
        {
            Hgettext.SetActive(true);
            
        }
        
        PlayerController.stop = false;//�N���t�g���̓v���C���[���~�߂�
    }
}
