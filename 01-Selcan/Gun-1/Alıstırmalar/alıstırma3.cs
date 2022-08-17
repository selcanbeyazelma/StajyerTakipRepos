using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma3 : MonoBehaviour
{
    int sayi;
    bool ciftsayimi;
   
   
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
        sayi = Random.Range(0, 101);
        if(sayi % 2 == 0)
        {
            ciftsayimi = true;
        }
        else
        {
            ciftsayimi= false;
        }
            Debug.Log(sayi);
            Debug.Log(ciftsayimi);
        
       }
    }
}
