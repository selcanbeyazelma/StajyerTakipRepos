using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma10 : MonoBehaviour
{
    string [] meyveler={"elma","armut","karpuz","muz","çilek"};
   
    void Start()
    {
         for (int i = 0; i < 5; i++)
         {
            Debug.Log(meyveler[i]);
         }
    }

    
    void Update()
    {
        
    }
}
