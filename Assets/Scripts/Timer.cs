using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
public class Timer : MonoBehaviour
{
    public List<Text> Delimeters = new List<Text>();
    public Text Hours;
    public Text Minutes;
    public Text Seconds;
    private float time  = 0;

    public float GetTime()
    {
        return time;
    }
    void Start()
    {
        this.SetTime(20,59,0f);
    }
    void Update()
    {
        if(time < 60)
        {
            time+=Time.deltaTime;
            if(!string.IsNullOrEmpty(Seconds.text))
            {
                Seconds.text = String.Format("{0:00}",time);
            }
        }
        else
        {
            this.SetTime(21,0,0f);
            Cursor.visible = true;
            SceneManager.LoadScene(3);
        }
    }
    
    public void SetTime(int Hours,int Minuts,float Seconds)
    {
        this.Hours.text = String.Format("{0:00}",Hours);
        this.Minutes.text = String.Format("{0:00}",Minuts);
        this.Seconds.text = String.Format("{0:00}",Seconds);
    }
}
