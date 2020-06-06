using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npctwo : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        enemy badguy = collision.gameObject.GetComponent<enemy>();
        if (collision.gameObject.tag == "Enemy")
        {
            anim.SetBool("running", false);
            Attack();
            badguy.health--;
            if (badguy.health != 0)
            {
                badguy.Block();
            }
            else
            {
                badguy.Killed();
            }
        }
    }
    private void Update()
    {
        rb.velocity = new Vector2(4, 0);
        transform.localScale = new Vector2(1, 1);
        anim.SetBool("running", true);
    }
    private void Attack()
    {
        anim.SetTrigger("attack");

    }
    private void poof()
    {
        gameObject.SetActive(false);
    }
}
