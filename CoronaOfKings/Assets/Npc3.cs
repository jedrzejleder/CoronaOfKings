using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc3 : MonoBehaviour
{
    public float npc3X;

    private void Awake()
    {
        npc3X = transform.position.x;
    }
    // Start is called before the first frame update
    void Start()
    {
        npc3X = transform.position.x;
    }
}
