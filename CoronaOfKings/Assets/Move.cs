using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 pos;
    Vector3 npc1Pos;
    Vector3 npc2Pos;
    Vector3 npc3Pos;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        npc1Pos = Npc1.npc1Pos;
        npc2Pos = Npc2.npc2Pos;
        npc3Pos = Npc3.npc3Pos;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && pos.x != startPos.x)
        {
            pos = transform.position;
            pos.x = startPos.x;
            transform.position = pos;
        }*/
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && pos.x == npc1Pos.x - 2)
        {
            pos = transform.position;
            pos.x = startPos.x;
            transform.position = pos;
        }
        else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && pos.x == npc2Pos.x - 2)
        {
            pos = transform.position;
            pos.x = npc1Pos.x - 2;
            transform.position = pos;
        }
        else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && pos.x == npc3Pos.x - 2)
        {
            pos = transform.position;
            pos.x = npc2Pos.x - 2;
            transform.position = pos;
        }
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && pos.x == startPos.x)
        {
            pos = transform.position;
            //pos.x += 2;
            //transform.position = pos;
            pos.x = (npc1Pos.x) - 2;
            transform.position = pos;
        }
        else if((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && pos.x == npc1Pos.x - 2)
        {
            pos = transform.position;
            //pos.x += 2;
            //transform.position = pos;
            pos.x = (npc2Pos.x) - 2;
            transform.position = pos;
        }
        else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && pos.x == npc2Pos.x - 2)
        {
            pos = transform.position;
            //pos.x += 2;
            //transform.position = pos;
            pos.x = (npc3Pos.x) - 2;
            transform.position = pos;
        }
    }
}
