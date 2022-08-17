using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelseyapısı : MonoBehaviour
{
   
     // int a =1;
     // int b=2;
        int a;
    void Start()
    {
     
     a = Random.Range(1,6);
     Debug.Log(a);
      if (a ==1 )
      {
        Debug.Log("A=1");
      }
      else if(a==2)
      {
        Debug.Log("a =2");
      }
       else if(a>=3)
      {
        Debug.Log("a 3 e eşit veya 3 den büyük");
      }
      else 
      {
        Debug.Log("a =0");
      }
     
     
     
     //  if(a == 1)
      // {
     //   Debug.Log("A değişkeni 1 e eşit");
     //  }
     //  else if(a == 2)
     //  {
     //   Debug.Log("a değişkeni 2 ye eşit.");
     //  }
     //  else if(a == 3)
     //  {
     //   Debug.Log("a değişkeni 3 e eşit.");
     //  }
     //  else
     //  {
     //   Debug.Log("A değişkeni 1 e eşit değil");
     //  }
     //if (a == 1)
    // {
     //   if (b == 2)
     //   {
        //if içerisinde if tanımlanabilir.
      //  }
      //  else{

      //  }
    // }
    // else{

    // }

    }

    
    void Update()
    {
        
    }
}
