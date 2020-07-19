using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text Hours;
    public Text Minutes;
    public Text Seconds;
    public float time = 0;
    void Start()
    {
        this.SetTime(20,59,0f);
    }
    void Update()
    {
        if(time < 30)
        {
            time+=Time.deltaTime;
            Seconds.text = String.Format("{0:00}",time);
        }
        else
        {
            this.SetTime(21,0,0f);
        }
    }
    public void SetTime(int Hours,int Minuts,float Seconds)
    {
        this.Hours.text = String.Format("{0:00}",Hours);
        this.Minutes.text = String.Format("{0:00}",Minuts);
        this.Seconds.text = String.Format("{0:00}",Seconds);
    }
}
