using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody_player;
    [Header("人物参数")]
    public float speed;
    public float next_try = 0;
    public float cd_try;
    private float x, y;
    public Vector3 target_pos;
    public GameObject Fade;
    Vector3 OFFSET;
    Quaternion rotation;
    void Start()
    {
        rigidbody_player = GetComponent<Rigidbody2D>();
        target_pos = transform.position;
        OFFSET = Camera.main.transform.position - transform.position;
        rotation = Camera.main.transform.rotation;
    
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = transform.position + OFFSET;
        check_Map();
    }

    private void FixedUpdate()
    {
        check(); 
    }

    void MoveMent_player() {
        if (Fade.activeInHierarchy == true) return;
       x = Input.GetAxisRaw("Horizontal");
       y= Input.GetAxisRaw("Vertical");
        if (x != 0&&y!=0) y = 0;
        target_pos+= new Vector3(x, y, 0);
        
        x = 0;y = 0;

      
    }

    void check() {
        rigidbody_player.MovePosition(Vector2.Lerp(transform.position, target_pos, speed*Time.deltaTime));
        if (Time.time > next_try) {
            MoveMent_player();
            next_try += cd_try;   
        }    
    }

    void check_Map() {
        if (Input.GetKey((KeyCode.Space)))
        {
            Camera.main.orthographic = true;
            Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else { 
            Camera.main.orthographic = false;
            Camera.main.transform.rotation = rotation;
        }
    
    }
}
