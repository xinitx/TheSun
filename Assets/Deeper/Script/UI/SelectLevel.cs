using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public GameObject Fader;
    public void Start()
    {
        Fader = GameObject.Find("Fade");
    }
    public void Back()
    {
        Fader.SetActive(true);
        Fade.instance.Change_Scene(0);
        //SceneManager.LoadScene(0);
    }

}