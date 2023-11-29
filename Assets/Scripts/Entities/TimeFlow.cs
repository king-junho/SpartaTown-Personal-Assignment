using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.UI;

public class TimeFlow : MonoBehaviour
{
    [SerializeField] Text timeText;

    private void Start()
    {
        timeText.text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");
    }
    void Update()
    {
        timeText.text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00");
    }
}
