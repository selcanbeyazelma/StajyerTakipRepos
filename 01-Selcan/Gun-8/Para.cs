using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Para : MonoBehaviour
{

    public Text paraText;

    private void Start()
    {
        PlayerPrefs.SetInt("para", 100);
    }
    private void Update()
    {
        paraText.text = PlayerPrefs.GetInt("para").ToString();
    }

}
