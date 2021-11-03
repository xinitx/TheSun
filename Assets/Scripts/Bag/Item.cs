using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private int label;
    private void Start()
    {
        if (GameManage.instance.collect[label] == 1)
        {
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManage.instance.getItem(label);
            Destroy(gameObject);
        }
    }
}
