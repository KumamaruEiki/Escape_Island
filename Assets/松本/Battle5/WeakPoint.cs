using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoint : MonoBehaviour
{
    public GameObject weakPoint;//�E�B�[�N�|�C���g�I�u�W�F�N�g
    public static int WHP=10;//�I�I�J�~��HP�ϐ������l10

    public float keikatime;//�o�ߎ��ԑ���p
    public static bool pointFlg=true;//�|�C���g���A�N�e�B�u���ǂ�������p
    public float activetime;//�A�N�e�B�u�ɂȂ�܂ł̎���

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      if (Input.GetMouseButtonDown(0)&&StartC.onclick)
        {
            //�N���b�N�����Ƃ�Ray���΂�
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hitSprite = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hitSprite == true)
            {
                //��΂�����ɃQ�[���^�O�iweak�j���Ȃ������ׂ�
                weakPoint = hitSprite.transform.gameObject;
                if (weakPoint.tag == "weak")
                {
                    //�q�b�g�����Ƃ��E�B�[�N�|�C���g���ꎞ�I�ɉB��
                    weakPoint.SetActive(false);
                    WHP--;//�I�I�J�~��HP�����炷
                    pointFlg = false;
                    
                }
            }
        }
        
     
    }
}
