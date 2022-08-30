using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DolarTopla : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Selcan")
        {
            PlayerPrefs.SetInt(
                "para",
                (PlayerPrefs.GetInt("para") + 1000));
            this.gameObject.SetActive(false);
        }
    }
}
