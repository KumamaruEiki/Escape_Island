using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //�e�X�e�[�W�̃t���O�Ǘ�
    public static bool Battele1Flg   = false;
    public static bool Battele3Flg   = false;
    public static bool Battele4_1Flg = false;
    public static bool Battele4_2Flg = false;
    public static bool Battele5Flg   = false;
    public static bool BowFlg        = false;
    public static bool HandleFlg     = false;

    //�e�V�[�����[�h���̏o���ꏊ�ݒ�
    public static Vector3 M1_1pos = new Vector3(-1.5f,  3.5f, 0);//���C��1�̏o���ꏊ     1
    public static Vector3 M2_1pos = new Vector3(-1.5f, -4.5f, 0);//���C��2�̉��̏o���ꏊ 2
    public static Vector3 M2_2pos = new Vector3(-9.5f, -0.5f, 0);//���C��2�̉E�̏o���ꏊ 3
    public static Vector3 M3_1pos = new Vector3( 6.5f, -0.5f, 0);//���C��3�̉E�̏o���ꏊ 4
    public static Vector3 M3_2pos = new Vector3(0, 0, 0);//���C��3�̉��̏o���ꏊ 5
    public static Vector3 M3_3pos = new Vector3(0, 0, 0);//���C��3�̍��̏o���ꏊ 6
    public static Vector3 M4_1pos = new Vector3(0, 0, 0);//���C��4�̏�̏o���ꏊ 7
    public static Vector3 M4_2pos = new Vector3(0, 0, 0);//���C��4�̍��̏o���ꏊ 8
    public static Vector3 M4_3pos = new Vector3(0, 0, 0);//���C��4�̉E�̏o���ꏊ 9
    public static Vector3 M5_1pos = new Vector3(0, 0, 0);//���C��5�̉��̏o���ꏊ 10
    public static Vector3 M5_2pos = new Vector3(0, 0, 0);//���C��5�̏�̏o���ꏊ 11

    public static int Loadpos;//���C���V�[���̂ǂ̈ʒu�ɏo�����邩�̕ϐ�

    public static int meinnum;//�ǂ̃��C���V�[���Ɉړ����邩�̕ϐ�


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
