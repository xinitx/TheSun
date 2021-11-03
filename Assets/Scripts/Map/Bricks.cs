using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    //得到空气墙
    [SerializeField]
    private GameObject wall;
    [SerializeField]
    private GameObject decay;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            //创建空气墙
            Instantiate(wall, transform.position + new Vector3(0, -0.12f, 0), transform.rotation);
            //播放动画
            Instantiate(decay, transform.position + new Vector3(0 ,-0.12f, 0), transform.rotation);
            //删除当前方块
            Destroy(gameObject);
        }
    }
    public void destroy()
    {
        Destroy(gameObject);
    }
}
