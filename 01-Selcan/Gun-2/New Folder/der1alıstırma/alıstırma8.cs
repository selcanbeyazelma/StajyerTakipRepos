 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma8 : MonoBehaviour
{
   int tekrarlanan=1;
   int degisken;
   int ellidenbuyuk_sayi;
    void Start()
    {
        while (tekrarlanan<11)
        {
            degisken=Random.Range(1,101);
            if(degisken>50){
                ellidenbuyuk_sayi++;
            }
            Debug.Log(degisken);
            tekrarlanan++;
        }
            Debug.Log(ellidenbuyuk_sayi + "tane 50'den büyük sayı vardır");
    }

   
    void Update()
    {
        
    }
}
