using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma2 : MonoBehaviour
{
    bool degisken;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            degisken= !degisken;
            Debug.Log(degisken);
        }
    }
}
