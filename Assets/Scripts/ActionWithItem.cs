using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionWithItem : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0));
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "beer")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
