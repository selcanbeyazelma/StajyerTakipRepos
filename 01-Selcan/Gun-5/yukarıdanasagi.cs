using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukarıdanasagi : MonoBehaviour
{
    public float hiz;
    void Start()
    {
        hiz = 0;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -1 * Time.deltaTime, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Time.deltaTime * hiz, 0, 0);
        }
    }
}
