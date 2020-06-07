using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc3S3 : MonoBehaviour
{
    public static int nr;
    public Rigidbody2D lb;
    public Animator anim = new Animator();
    //bool xd = Move.xd;
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nr = 3;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nr = 0;
    }
    public void ExitRightAnswer()
    {
        anim.SetBool("tuptani3", true);
        transform.localScale = new Vector2(-1, 1);
        lb.velocity = new Vector2(2, 0);
    }
}
