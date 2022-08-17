using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileandfor : MonoBehaviour
{
   int a=0;
    void Start()
    {
        while(a<=100)
        {
            if(a%2 ==1){
                Debug.Log(a);
            }
            a++;
        }
    }

   
    void Update()
    {
        
    }
}
