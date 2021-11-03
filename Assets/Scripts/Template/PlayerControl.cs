using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public static PlayerControl instance;
    [SerializeField]
    private GameObject player;

    private bool can_move;
    private LayerMask brick;
    private Vector3 end_pos, dir;

    private void Awake()
    {
        if (instance != null)
            Destroy(this);
        instance = this;

        player = GameObject.FindGameObjectWithTag("Player");
        end_pos = player.transform.position;
        can_move = true;
        brick = LayerMask.GetMask("Brick");
    }

    private void FixedUpdate()
    {
        if (Time.timeScale != 0)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            Move();

        }
    }

    private void Move()
    {

        if (can_move && Input.GetKey(KeyCode.D))
        {
            RaycastHit2D jud = Physics2D.Raycast(player.transform.position + new Vector3(0.8f, 0, 0), Vector2.right, 0.3f, brick);
            if (jud)
            {
                dir = new Vector3(1, 0, 0);
                end_pos = player.transform.position + new Vector3(1, 0, 0);
                can_move = false;

            }
        }
        if (can_move && Input.GetKey(KeyCode.A))
        {
            RaycastHit2D jud = Physics2D.Raycast(player.transform.position + new Vector3(-0.8f, 0, 0), Vector2.left, 0.3f, brick);
            if (jud)
            {
                dir = new Vector3(-1, 0, 0);
                end_pos = player.transform.position + new Vector3(-1, 0, 0);
                can_move = false;
            }
        }
        if (can_move && Input.GetKey(KeyCode.S))
        {
            RaycastHit2D jud = Physics2D.Raycast(player.transform.position + new Vector3(0, -0.8f, 0), Vector2.down, 0.3f, brick);
            if (jud)
            {
                dir = new Vector3(0, -1, 0);
                end_pos = player.transform.position + new Vector3(0, -1, 0);
                can_move = false;

            }
        }
        if (can_move && Input.GetKey(KeyCode.W))
        {
            RaycastHit2D jud = Physics2D.Raycast(player.transform.position + new Vector3(0, 0.8f, 0), Vector2.up, 0.3f, brick);
            Debug.Log(1);
            if (jud)
            {
                dir = new Vector3(0, 1, 0);
                end_pos = player.transform.position + new Vector3(0, 1, 0);
                can_move = false;
                Debug.Log(2);
            }
        }
        if (Mathf.Abs((player.transform.position - end_pos).x) < 0.01f && Mathf.Abs((player.transform.position - end_pos).y) < 0.01f)
        {
            can_move = true;
            dir = Vector3.zero;
        }
        else
        {
            player.transform.position += dir * Time.deltaTime;
        }


    }
    public void transmit(Vector3 aim)
    {
        transform.position = aim;
        end_pos = transform.position;
    }
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawRay(player.transform.position + new Vector3(1, 0, 0), Vector2.right);
        Gizmos.DrawRay(player.transform.position + new Vector3(0, -1, 0), Vector2.down);
        Gizmos.DrawRay(player.transform.position + new Vector3(-1, 0, 0), Vector2.left);
        Gizmos.DrawRay(player.transform.position + new Vector3(0, 1, 0), Vector2.up);
        Gizmos.color = Color.black;
        Gizmos.DrawRay(player.transform.position + new Vector3(1.3f, 0, 0), Vector2.right);
        Gizmos.DrawRay(player.transform.position + new Vector3(0, -1.3f, 0), Vector2.down);
        Gizmos.DrawRay(player.transform.position + new Vector3(-1.3f, 0, 0), Vector2.left);
        Gizmos.DrawRay(player.transform.position + new Vector3(0, 1.3f, 0), Vector2.up);
    }
}
