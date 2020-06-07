﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Przejscie : MonoBehaviour
{
    public int index;
    public string levelName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //SceneManager.LoadScene(index);
            SceneManager.LoadScene(levelName);
        }
    }
}
