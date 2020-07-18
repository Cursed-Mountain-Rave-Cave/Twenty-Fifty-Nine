using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckListShower : MonoBehaviour
{
    public GameObject Canvas;
    bool onShow;
    void Start()
    {
        onShow = false;
        Canvas?.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
           this.onShow = !this.onShow;
            Canvas?.SetActive(onShow);
        }
    }
}
