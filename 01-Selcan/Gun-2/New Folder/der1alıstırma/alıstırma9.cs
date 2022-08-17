using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma9 : MonoBehaviour
{
    
    int degisken;
    int ellidenbuyuk_sayi;
    void Start()
    {
        ellidenbuyuk_sayi=0;
        
        for (int i = 0; i < 10; i++) {
            degisken=Random.Range(1,101);
            if(degisken>50){
                ellidenbuyuk_sayi++;
            }
            Debug.Log(degisken);
           
        }
            Debug.Log(ellidenbuyuk_sayi + "tane 50'den büyük sayı vardır");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
