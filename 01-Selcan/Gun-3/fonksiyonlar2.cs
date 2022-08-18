using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fonksiyonlar2 : MonoBehaviour
{
    void fordongusu(int a)
    {
        for (int i = 0; i < a; i++)
        {
            Debug.Log(i);
        }
    }
    void Start()
    {
        fordongusu(10);
    }

    
    void Update()
    {
        
    }
}
