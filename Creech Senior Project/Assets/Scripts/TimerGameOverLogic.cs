using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGameOverLogic : MonoBehaviour
{
    int countDownStartValue = 1800;
    public Text timerUI;

    //Start is called before the first update
    void Start()
    {
        countDownTimer();
    }
    
    void countDownTimer()
    {
        if(countDownStartValue > 0)
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
