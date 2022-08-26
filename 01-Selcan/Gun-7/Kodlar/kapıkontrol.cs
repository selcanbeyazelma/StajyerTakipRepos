using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapıkontrol : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "openanimation";
    [SerializeField] private string doorClose = "closeanimation";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Selcan"))
        {
            if (openTrigger)
            {
                myDoor.Play(doorOpen, 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                myDoor.Play(doorClose, 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Selcan"))
        {
            Debug.Log("Selcanss");
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Selcan"))
        {
            Debug.Log("hohuhohohu");
        }
    }

}
