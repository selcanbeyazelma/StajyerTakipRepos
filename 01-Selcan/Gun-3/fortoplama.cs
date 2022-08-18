using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fortoplama : MonoBehaviour
{

    public Text sayi;
    int[] dizi= new int[11];
    void Start()
    {
        toplam();
    }
    public void toplam()
    {
        int toplam = 0;
        for (int a = 0; a < 11; a++)
        {
            toplam += a;
            dizi[a] = toplam;

        }
        for (int i = 0; i < dizi.Length; i++)
        {
            sayi.text = dizi[i].ToString();
        }
    }


}
