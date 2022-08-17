using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alıstırma1 : MonoBehaviour
{
    int sayac;

    void Start()
    {
        sayac = 0;
    }

    void Update()
    {  //GetKey:klavyede bir tuşa basıldığında çalışır. sürekli basılırsa havada kalır.
        //GetKeyDown: tuşa sadece 1 kez bastırır ve basılı tutulduğunda olmaz.
        //getkeyup: tuştan elimiz kaldırılırsa çalışır.
        // 0 sol click, 1 sağ click.
        if (Input.GetMouseButtonDown(0))
        {
            sayac++;
            Debug.Log(sayac);
        }
    }
}
