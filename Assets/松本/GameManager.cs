using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //�e�X�e�[�W�̃t���O�Ǘ�
    public static bool Battele1Flg   = false;
    public static bool Battele3Flg   = false;
    public static bool Battele4_1Flg = false;
    public static bool Battele4_2Flg = false;
    public static bool Battele5Flg   = false;
    public static bool HandleFlg     = false;

    //�e�V�[�����[�h���̏o���ꏊ�ݒ�
    public static Vector3 M1_1pos = new Vector3(0, 0, 0);//���C��1�̏o���ꏊ     1
    public static Vector3 M2_1pos = new Vector3(0, 0, 0);//���C��2�̉��̏o���ꏊ 2
    public static Vector3 M2_2pos = new Vector3(0, 0, 0);//���C��2�̉E�̏o���ꏊ 3
    public static Vector3 M3_1pos = new Vector3(0, 0, 0);//���C��3�̉E�̏o���ꏊ 4
    public static Vector3 M3_2pos = new Vector3(0, 0, 0);//���C��3�̉��̏o���ꏊ 5
    public static Vector3 M3_3pos = new Vector3(0, 0, 0);//���C��3�̍��̏o���ꏊ 6
    public static Vector3 M4_1pos = new Vector3(0, 0, 0);//���C��4�̏�̏o���ꏊ 7
    public static Vector3 M4_2pos = new Vector3(0, 0, 0);//���C��4�̍��̏o���ꏊ 8
    public static Vector3 M4_3pos = new Vector3(0, 0, 0);//���C��4�̉E�̏o���ꏊ 9
    public static Vector3 M5_1pos = new Vector3(0, 0, 0);//���C��5�̉��̏o���ꏊ 10
    public static Vector3 M5_2pos = new Vector3(0, 0, 0);//���C��5�̏�̏o���ꏊ 11

    public static int Loadpos;//���C���V�[���̂ǂ̈ʒu�ɏo�����邩�̕ϐ�

    public static int meinnum;//�ǂ̃��C���V�[���Ɉړ����邩�̕ϐ�

    private AudioSource audioSource;

    [SerializeField] private AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //�Ȃ̕ύX
        if(meinnum==0)
        {
            //0�Ԃ̋Ȃ��Đ�
            audioSource.clip = clips[0];
        }
        if()
        else
        {
            //�P�Ԃ̋Ȃ��Đ�
            audioSource.clip = clips[1];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
