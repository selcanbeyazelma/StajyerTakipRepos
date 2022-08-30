using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text nameField;
    public Text HosgeldinText;

    // UIManager UIManager;

    private void Start()
    {
        StartCoroutine(Hosgeldiniz());

        //UIManager=GetComponent<UIManager>();
        //nameField.text = UIManager.message;
        nameField.text = PlayerPrefs.GetString("isim");
    }
    IEnumerator Hosgeldiniz()
    {
       HosgeldinText.text="Ho�geldiniz say�n "+ PlayerPrefs.GetString("isim")+ "G�l";
       yield return new WaitForSeconds(2f);
       HosgeldinText.text = "";
    }
}
