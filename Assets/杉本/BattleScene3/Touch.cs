using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject clickGameObject;
    public float indication_time;
    public GameObject target;
    public static bool click;

    public static int B3cnt=10;
    private int cnt;

    // Start is called before the first frame update
    void Start()
    {
        clickGameObject.SetActive(true);
        B3cnt = 10;
        click = false;
    }

    //�N���b�N���ꂽ��
    public void Onclick()
    {
        //�������Ăق����Ȃ��Ƃ�
        if (click == true||StartC.starttf==false|| direction.obstacles == true)
        {
            Debug.Log("NO");
            return;
        }
        //����������
        else
        {
            Debug.Log("cilck");
            click = true;
            StartCoroutine(Indication());
            B3cnt--;
        }
    }

    public IEnumerator Indication()
    {

        yield return new WaitForSeconds(indication_time);
        Touch.click = false;

        clickGameObject.transform.position = target.transform.position;
        //Debug.Log("a");

    }

    // Update is called once per frame
    void Update()
    {
        //���邵�\��
        if (direction.obstacles == false && Touch.click == false)
        {
            clickGameObject.SetActive(true);
        }
        //��\��
        else if (direction.obstacles == true || Touch.click == true)
        {
            clickGameObject.SetActive(false);
        }
    }    
}
