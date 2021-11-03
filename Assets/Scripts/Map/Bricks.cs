using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    //�õ�����ǽ
    [SerializeField]
    private GameObject wall;
    [SerializeField]
    private GameObject decay;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            //��������ǽ
            Instantiate(wall, transform.position + new Vector3(0, -0.12f, 0), transform.rotation);
            //���Ŷ���
            Instantiate(decay, transform.position + new Vector3(0 ,-0.12f, 0), transform.rotation);
            //ɾ����ǰ����
            Destroy(gameObject);
        }
    }
    public void destroy()
    {
        Destroy(gameObject);
    }
}
