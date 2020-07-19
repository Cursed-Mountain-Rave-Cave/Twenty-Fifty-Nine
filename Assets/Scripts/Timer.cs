using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
public class Timer : MonoBehaviour
{
    public List<Text> Delimeters = new List<Text>();
    public Text Hours;
    public Text Minutes;
    public Text Seconds;
    private float time  = 0;
    void Start()
    {
        this.SetTime(20,59,0f);
        StartCoroutine(BlinkText()); 
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
        }
    }
    
    public void SetTime(int Hours,int Minuts,float Seconds)
    {
        this.Hours.text = String.Format("{0:00}",Hours);
        this.Minutes.text = String.Format("{0:00}",Minuts);
        this.Seconds.text = String.Format("{0:00}",Seconds);
    }
    public IEnumerator BlinkText()
    {
        while(true)
        {
            Delimeters.ForEach((x)=>x.text = "");
            yield return new WaitForSeconds(.5f);
            Delimeters.ForEach((x)=>x.text = ":");
            yield return new WaitForSeconds(.5f);
        }
    }
}
