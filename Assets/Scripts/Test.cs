using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
public class Test : MonoBehaviour
{
    public void close()
    {

        SceneManager.UnloadSceneAsync(1);
    }
    public void open()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Additive);

    }
}
