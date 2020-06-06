using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Animator anim2;
    public Rigidbody2D lb;
    void Start()
    {
        
    }

    public void Killed()
    {
        anim2.SetTrigger("dead");
    }
    public void Block()
    {
        anim2.SetTrigger("block");
    }

    private void Death()
    {
        Destroy(this.gameObject);
    }
}
