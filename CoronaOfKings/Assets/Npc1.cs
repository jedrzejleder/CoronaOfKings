using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc1 : MonoBehaviour
{
    public float npc1X;
    public Vector3 npc1Vec;

    private void Awake()
    {
        npc1X = transform.position.x;
        npc1Vec = transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        npc1X = transform.position.x;
        npc1Vec = transform.position;
    }
}
