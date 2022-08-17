using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma4 : MonoBehaviour
{
    //public string isim;
    public bool denetim;
    string sonuc;
    void Start()
    {
        //Debug.Log(isim);
        if (denetim == true)
        {
            sonuc = "Başarılı!";
        }
        else
        {
            sonuc= "Başarısız";
        }
        Debug.Log(sonuc);
    }

    
    void Update()
    {
        
    }
}
