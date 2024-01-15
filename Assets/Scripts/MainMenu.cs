using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void InfoPage()
    {
        SceneManager.LoadScene("Info Page");
    }

}
