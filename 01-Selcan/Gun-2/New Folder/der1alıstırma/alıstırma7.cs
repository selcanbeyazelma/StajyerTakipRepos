using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma7 : MonoBehaviour
{
    int degisken;
    void Start()
    {
      
    }

    
    void Update()
    {
          if(Input.GetMouseButtonDown(0)){
            degisken=Random.Range(1,101);
            Debug.Log(degisken);
            if(degisken>50){
                Debug.Log("50'den büyük!");
            }
           if(degisken<50){
            Debug.Log("50'den küçük");
           }
           if(degisken==50){
            Debug.Log("50'ye eşit.");
           }
        }
    }
}
