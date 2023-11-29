using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoginButton : MonoBehaviour
{
    [SerializeField] Text InputText;
    [SerializeField] Button button;
    static public string PlayerID;

    public void Login()
    {
        if (InputText.text.Length<2 || InputText.text.Length > 10)
        {
            button.interactable = false;
        }
        else
        {
            PlayerID = InputText.text;
            SceneManager.LoadScene("MainScene");
        }

    }
}
