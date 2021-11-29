using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
    // Start is called before the first frame
    public GameObject TheOther_Flame;
    public bool isUsed = false;
    bool hasEntered = false;
    //public float time_period = 1;
    bool canMove = false;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasEntered == true) {
            Invoke("Destroy_Flame", 3);
        }
    }
   

    public void OnTriggerStay2D(Collider2D collision)
    {
        hasEntered = true;
        if (collision.CompareTag("Player")&& TheOther_Flame.GetComponent<Flame>().isUsed==false&&isUsed==false) {
            isUsed = true;
            Invoke("PlayerMovement", 1);
            //PlayerMovement();
        }

        
    }

    void PlayerMovement() {

        GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>().enabled = false;
        GameObject.FindGameObjectWithTag("Player").transform.position= TheOther_Flame.transform.position;
        GameObject.FindGameObjectWithTag("Player").GetComponent<player>().target_pos = TheOther_Flame.transform.position;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>().enabled = true;
    }

    void Destroy_Flame() {
        Destroy(this.gameObject);
    }




}
