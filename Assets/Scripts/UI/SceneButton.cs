using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    [SerializeField]
    private int tar_scene;
    [SerializeField]
    private int cur_scene;
    [SerializeField]
    private int gamelevel;
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject audios;
    [SerializeField]
    private GameObject events;
    public void jmp()
    {
            audios.SetActive(false);
            events.SetActive(false);
            SceneManager.LoadScene(tar_scene, LoadSceneMode.Additive);
    }
    public void goback()
    {
        SceneManager.GetActiveScene().GetRootGameObjects()[0].SetActive(true);
        SceneManager.GetActiveScene().GetRootGameObjects()[1].SetActive(true);
        SceneManager.UnloadSceneAsync(cur_scene);
    }
    public void exit()
    {
        Application.Quit();
    }
    public void button()
    {
        if(menu.activeInHierarchy)
            menu.SetActive(false);
         else
            menu.SetActive(true);
    }
    public void newgame()
    {
        SceneManager.LoadScene(gamelevel, LoadSceneMode.Single);
    }
    public void continu_game()
    {
        int buf = PlayerPrefs.GetInt("level");
        if( buf != 0)
            SceneManager.LoadScene(buf, LoadSceneMode.Single);
    }
    public void store_game()
    {
        PlayerPrefs.SetInt("level", SceneManager.GetActiveScene().buildIndex);
    }
}
