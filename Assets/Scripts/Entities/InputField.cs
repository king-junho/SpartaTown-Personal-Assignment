using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField : MonoBehaviour
{
    [SerializeField] Button loginBtn;
    public void IsValueChange()
    {
        loginBtn.interactable = true; 
    }
}
