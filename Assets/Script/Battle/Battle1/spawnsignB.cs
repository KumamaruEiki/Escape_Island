using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnsignB : MonoBehaviour
{

    public GameObject createPrefab;
    public GameObject[] SpawnPoint;
    public GameObject TouchSignA;
    public float Spawntime;
    public float time;
    public bool IsSpawn;
    

    // Start is called before the first frame update

    void Start()
    {
        //Debug.Log("ugoiteru");

    }

    IEnumerator Spawn()
    {
        time = 4.0f;
        while (SignA.ClickSignA)
        {
            IsSpawn = true;
            //�����_���Ő�������ꏊ�̌���
            int RandSpawn = Random.Range(0, 4);


            //�v���n�u�������I�u�W�F�N�g�̈ʒu�Ɍ��肵���ꏊ������
            createPrefab.transform.position = SpawnPoint[RandSpawn].transform.position;
            
            //����
            Instantiate(createPrefab);
            
            yield return new WaitForSeconds(Spawntime);

            time -= 1.0f;
            if(time<0)
            {
                TouchSignA.SetActive(true);
                SignA.ClickSignA = false;
                IsSpawn = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(!IsSpawn)
        StartCoroutine(Spawn());
    }
}
