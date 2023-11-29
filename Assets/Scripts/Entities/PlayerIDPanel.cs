using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIDPanel : MonoBehaviour
{
    [SerializeField]Text IDText;
    public string playerID;
    private void Awake()
    {

        IDText.text = LoginButton.PlayerID;
    }
}
