using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestorysignB : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //��ʂ̉��܂ŗ���������폜
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
