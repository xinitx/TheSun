using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public static Test2 instance;
    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;
    }
}
