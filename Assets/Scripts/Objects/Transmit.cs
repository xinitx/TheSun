using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmit : MonoBehaviour
{
    public GameObject aim;
    public Transform brick;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            
            Player.instance.transmit(brick.position);
            Destroy(aim);
            Destroy(gameObject);
           
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Brick"))
        {
            brick = collision.gameObject.transform;
        }
    }
}
