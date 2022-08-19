using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    Rigidbody yercekimi;
    public int guc;

    private float yatayhareket;
    public float harekethýzý;

    void Start()
    {
        yercekimi= GetComponent<Rigidbody>();
    }


    void Update()
    {
       float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        
        Vector3 vec = new Vector3(yatay, 0 , yatay);
        yercekimi.AddForce(vec * guc);
    }
}
