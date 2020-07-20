using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AimController : MonoBehaviour
{
    private Text text;
    public CheckListView checkListView;
    private string aim;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void FixedUpdate() {
        aim = "+";
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width * 0.5f, Screen.height * 0.5f, 0));
        if (Physics.SphereCast(ray, Config.SPHERECAST_SPHERE_RADIUS, out hit, Config.MAX_RAYCAST_DISTANSE))
        {
            if (checkListView.HasTag(hit.collider.tag) ||
                hit.collider.tag == "kassa" && checkListView.LabelCheckBox.Count == 0)
            {
                aim = "O";
            }
        }
        text.text = aim;
    }
}
