using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextareaManager : MonoBehaviour
{
    public GameObject NextArea;//�l�N�X�g�G���A

    // Start is called before the first frame update
    void Start()
    {
        NextArea.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(GoalManager.BattleClearFlg1)
        {
            NextArea.SetActive(true);
        }
    }
}
