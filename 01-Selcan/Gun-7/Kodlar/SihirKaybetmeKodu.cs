using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SihirKaybetmeKodu : MonoBehaviour
{
    public Text paraText;
    public int para=100;
    private void Start()
    {
        paraText.text = para + " TELEE";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Selcan")
        {
            para += 100;
            paraText.text = para + " TELEE";
            //this.gameObject.transform.position=other.gameObject.transform.position;
            this.gameObject.SetActive(false);
        }
    }
}
