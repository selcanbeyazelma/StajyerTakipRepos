using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//sahne ynet�m� yukleme c�kma vs
using UnityEngine.XR;

public class UIManager : MonoBehaviour
{
    public InputField nameField;


    public Text ispat;

    public void GirisYap()
    {
        PlayerPrefs.SetString("isim", nameField.text);

        SceneManager.LoadScene(1);
    }
    public void CikisYap()
    {
        Debug.Log("Selcan ��k�� Butonuna Bast�!");
        //Application.Quit();
    }
    public void OnSubmit()
    {
        if (nameField.text=="")
        {
            ispat.text = "Doldur";
        }
        else
        {
            PlayerPrefs.SetString("isim", nameField.text);
            ispat.text ="�sminiz :"+ PlayerPrefs.GetString("isim");
        }
       
    }
}
