using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Animation : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;

    [Header("关于地板的一些参数")]
    public bool Istouched = false;
    public bool Touched;
    public LayerMask layer;
    public float radius;
    public bool IsCalculated = false;
    void Start()
    {
        animator = GetComponent<Animator>();
        reset_layer_order();
    }

    // Update is called once per frame
    void Update()
    {
        Check_Player();
    }

    public void Finish() {
        Destroy(this.gameObject);
    }

    void Check_Player() {
        Touched = Physics2D.OverlapCircle(transform.position, radius, layer);
        if (Touched == true&&IsCalculated==false) { Istouched = true;GameManager.instance.Destroy(1); IsCalculated = true; }
        if (Istouched == true && Touched == false) {
            animator.SetTrigger("Destoryed");
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }

    public void reset_layer_order() {
        this.gameObject.GetComponent<SpriteRenderer>().sortingOrder = this.transform.parent.GetComponent<Grid_order>().layer_order;
    }

}
