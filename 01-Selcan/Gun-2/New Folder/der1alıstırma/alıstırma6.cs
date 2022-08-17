using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma6 : MonoBehaviour
{
    int degisken;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            degisken = Random.Range(1, 11);
            Debug.Log(degisken);
            if(degisken % 2 == 0){
                Debug.Log("Sayı çifttir.");
            }
            else{
                Debug.Log("Sayı tektir.");
            }
        }
    }
}
