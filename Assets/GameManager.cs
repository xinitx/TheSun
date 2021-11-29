using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int Floor_number = 0;
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(this); } 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Floor_number == 0) {
            UIManager.instance.Next_Scene();
        }
    }

    public void Destroy(int number)
    {
        Floor_number--;
    }
}
