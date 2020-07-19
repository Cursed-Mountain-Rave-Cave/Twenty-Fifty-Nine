using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckListShower : MonoBehaviour
{
    public GameObject ViewList;
    public GameObject Phone;
    public bool onShow;
    void Start()
    {
        ViewList?.SetActive(false);
        Phone?.SetActive(false);
        onShow = false;
    }
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            ViewList?.SetActive(false);
            onShow = false;
        }
        if(Input.GetKeyDown(KeyCode.E) && !onShow)
        {
            ViewList?.SetActive(true);
            onShow = true;
        }
        if(Input.GetKeyUp(KeyCode.Q))
        {
            Phone?.SetActive(false);
            onShow = false;
        }
        if(Input.GetKeyDown(KeyCode.Q) && !onShow)
        {
            Phone?.SetActive(true);
             onShow = true;
        }
    }
}
