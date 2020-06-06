using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.5f;
    public Animator anim = new Animator();
    public Rigidbody2D lb;
    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
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
        else
        {
            anim.SetBool("tuptani", false);
        }
    }
}