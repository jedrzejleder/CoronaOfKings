using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();

    }
    public float speed = 1.5f;
    // Update is called once per frame
    void Update()
    {

        if (transform.position.x<-9)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (anim != null)
            {
                anim.Play("walk");

            }

        }
        else
        {
            anim.Play("idlemainchar");

        }
    }


}