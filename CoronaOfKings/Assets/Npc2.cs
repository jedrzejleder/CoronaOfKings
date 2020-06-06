using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc2 : MonoBehaviour
{
    public float npc2X;

    private void Awake()
    {
        npc2X = transform.position.x;
    }
    // Start is called before the first frame update
    void Start()
    {
        npc2X = transform.position.x;
    }
}
