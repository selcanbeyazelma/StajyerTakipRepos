using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TLTopla : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Selcan")
        {
            PlayerPrefs.SetInt(
                "para",
                (PlayerPrefs.GetInt("para")+10));
            this.gameObject.SetActive(false);
        }
    }
}
