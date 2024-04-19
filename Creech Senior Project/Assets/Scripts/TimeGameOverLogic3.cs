using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeGameOverLogic3 : MonoBehaviour
{
    int countDownStartValue = 3000;
    public Text timerUI;

    //Start is called before the first update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer: " + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "GameOver!";
        }
    }
}
