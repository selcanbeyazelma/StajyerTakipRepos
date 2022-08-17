using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booleanandstring : MonoBehaviour
{
     string stringtanim="string tanımı: bir yazı değişkenidir. tırnak içinde yazılır.";
     string booltanim= "bool tanımı:sadece true ve false arasında geçiş yapabilir.";  
   


    void Start()
    {
       Debug.Log(stringtanim);
       Debug.Log(booltanim);
    }

   
    void Update()
    {
        
    }
}
