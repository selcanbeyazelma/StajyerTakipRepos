using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asagıdanyukari : MonoBehaviour
{
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 1 * Time.deltaTime, 0, Space.World);
        }
    }
}
