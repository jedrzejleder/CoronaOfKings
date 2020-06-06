using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class visibile : MonoBehaviour
{
    public GameObject doit,master;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        doit.transform.localScale = new Vector3(20, 20, 0);
    }

    private Vector3 Vector3(float v1, float v2, int v3)
    {
        throw new NotImplementedException();
    }



    // Update is called once per frame
    void Update()
    {
        position = master.transform.position;
        if (position.x > 0.5)
        {
            doit.transform.localScale = new Vector3(1, 1, 1);
        }

        if (position.x > 11)
        {
            SceneManager.LoadScene(0);
        }
    }


}
