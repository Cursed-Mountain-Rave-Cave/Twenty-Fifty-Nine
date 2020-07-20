using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    public Text Score;
    public Text Record;
    public Text ChangeRecord;

    void Start()
    {
        if(GlobalVariable.time < GlobalVariable.recordTime)
        {
            GlobalVariable.recordTime = GlobalVariable.time;
            ChangeRecord.enabled = true;
        }
        Score.text = "Время прохождения: " + GlobalVariable.time + " Сек.";
        Record.text = "Самое быстрое прохождение: " + GlobalVariable.recordTime + " Сек.";
    }

    
}
