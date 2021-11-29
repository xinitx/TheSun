using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject Fader;
    public void NewGame()
    {
        Fader.SetActive(true);
        Fade.instance.Change_Scene(6);
        //SceneManager.LoadScene(1);
    }

    public void ContinueGame()
    {
        Fader.SetActive(true);
        Fade.instance.Change_Scene(1);
        //SceneManager.LoadScene(2);
    }

    public void Setting()
    {
        Fader.SetActive(true);
        Fade.instance.Change_Scene(2);
        //SceneManager.LoadScene(3);
    }

    public void About()
    {
        Fader.SetActive(true);
        Fade.instance.Change_Scene(3);
        //SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
