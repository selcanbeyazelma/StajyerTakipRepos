using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma5 : MonoBehaviour
{
   float ortalama;
   public float not1, not2,not3;
    void Start()
    {
        ortalama = (not1+ not2+ not3)/3;
        Debug.Log(ortalama);
        if(ortalama>=50){
            Debug.Log("Öğrenci geçti");
        }
        else
        {
            Debug.Log("Öğrenci kaldı!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
