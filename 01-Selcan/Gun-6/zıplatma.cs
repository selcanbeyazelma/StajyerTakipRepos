using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zıplatma : MonoBehaviour
{
    public float hiz = 10f;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(new Vector3(0, hiz, 0), ForceMode.Impulse);
        }
    }
}
