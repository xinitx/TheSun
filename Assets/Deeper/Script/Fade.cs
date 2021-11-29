using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    // Start is called before the first frame update
    public int SCENE;
    public static Fade instance;
    private Animator animator;
    public void Awake()
    {
        if (instance == null)
            instance = this;
        else Destroy(this.gameObject);

        
    }
    void Start()
    {
        animator = this.GetComponent<Animator>();
        animator.Play("Fade_out");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Change_Scene(int number)
    {
        SCENE = number;
    }

    public void Goto_Scene() {
        SceneManager.LoadScene(SCENE);
        }


    public void Hide_fade() {
        this.gameObject.SetActive(false);
    }
}
