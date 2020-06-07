using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc2S2 : MonoBehaviour
{
    public static int nr;
    public Rigidbody2D lb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        nr = 2;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nr = 0;
    }
    public void ExitRightAnswer()
    {

    }
}
