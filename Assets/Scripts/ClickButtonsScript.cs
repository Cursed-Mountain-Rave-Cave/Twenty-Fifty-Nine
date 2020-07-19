using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButtonsScript : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonNext()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
