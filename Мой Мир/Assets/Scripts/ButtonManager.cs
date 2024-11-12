using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public void ButtonRestart()
    {
        SceneManager.LoadScene("GalleryScene");
    }

    public void ButtonExit()
    {
        Application.Quit();
    }
}
