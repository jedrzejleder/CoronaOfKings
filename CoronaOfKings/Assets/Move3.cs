using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour
{
    public float speed = 1.5f;
    public Animator anim = new Animator();
    public Rigidbody2D lb;
    GameObject npc1Obj;
    GameObject npc2Obj;
    GameObject npc3Obj;
    int npc1 = 0;
    int npc2 = 0;
    int npc3 = 0;
    public static bool xd = false;


    private void Awake()
    {
        npc1Obj = GameObject.FindGameObjectWithTag("NPC1");
        npc2Obj = GameObject.FindGameObjectWithTag("NPC2");
        npc3Obj = GameObject.FindGameObjectWithTag("NPC3");
    }

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        npc1 = Npc1S3.nr;
        npc2 = Npc2S3.nr;
        npc3 = Npc3S3.nr;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            lb.velocity = new Vector2(2, 0);
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("tuptani", true);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            lb.velocity = new Vector2(-2, 0);
            transform.localScale = new Vector2(-1, 1);
            anim.SetBool("tuptani", true);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (npc1 == 1)
            {
                Debug.Log(npc1);
                npc1Obj.GetComponent<Npc1S3>().ExitRightAnswer();
            }

            if (npc2 == 2)
            {
                Debug.Log(npc2);              
                npc2Obj.GetComponent<Npc2S3>().ExitRightAnswer();
            }

            if (npc3 == 3)
            {
                Debug.Log(npc3);
                npc3Obj.GetComponent<Npc3S3>().ExitRightAnswer();
                xd = true;
            }
            if ((npc1 == 0 && npc2 == 2 && npc3 == 0) ||
                (npc1 == 1 && npc2 == 0 && npc3 == 0) ||
                (npc1 == 0 && npc2 == 0 && npc3 == 0))
            {
                Debug.Log("wypixddertdalam");
                xd = true;
            }

        }
        else
        {
            anim.SetBool("tuptani", false);
        }

        if (xd)
        {
            lb.velocity = new Vector2(2, 0);
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("tuptani", true);
        }
    }
}
