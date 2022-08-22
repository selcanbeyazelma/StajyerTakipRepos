using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class küre : MonoBehaviour
{
    public float hiz;
    void Start()
    {
        hiz = 0;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Time.deltaTime * -1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Time.deltaTime * hiz, 0, 0);
        }
    }
}

