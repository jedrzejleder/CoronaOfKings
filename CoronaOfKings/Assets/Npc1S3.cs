using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc1S3 : MonoBehaviour
{
    public static int nr;
    public Rigidbody2D lb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        nr = 1;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nr = 0;
    }
    public void ExitRightAnswer()
    {
        transform.localScale = new Vector2(-1, 1);
        lb.velocity = new Vector2(2, 0);
    }
}
