using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckListShower : MonoBehaviour
{
    public GameObject ViewList;
    void Start()
    {
        ViewList?.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.E))
        {
            ViewList?.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            ViewList?.SetActive(true);
        }
    }
}
