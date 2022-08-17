using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diziler : MonoBehaviour
{
    
    void Start()
    {

       // string[] sınıftaki_ogrenciler ={"görkem","selcan","ayşe","elif"};

       // int[] itemsayi = {3,18,1};

       string[] sınıflistesi= {"ayşe","fatma","ali","melisa","mehmet"};
        
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(sınıflistesi[i]);
        }
    }

    
    void Update()
    {
        
    }
}
