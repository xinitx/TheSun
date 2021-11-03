using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManage : MonoBehaviour
{
    public static GameManage instance;
    [SerializeField]
    public int size;
    public int[] collect;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;

        collect = new int[size];
        if (!PlayerPrefs.HasKey("bag"))
        {
            int[] buf = new int[size];
            for (int i = 0; i < size; i++ )
                buf.SetValue(0, i);
            PlayerPrefsX.SetIntArray("bag", buf);
            PlayerPrefs.Save();
        }
        else
        {
            collect = PlayerPrefsX.GetIntArray("bag");
        }
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.Save();
        }

    }
    public void getItem(int buf)
    {
        instance.collect.SetValue(1, buf);
        PlayerPrefsX.SetIntArray("bag", collect);
    }
}
