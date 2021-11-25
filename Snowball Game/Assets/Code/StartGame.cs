using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
   public bool gameStarted = false;
    void Start()
    {
     
    }

    void Update()
    {
        if (gameStarted == false)
        {
            Time.timeScale = 0;
            print("x");
        }
        if (gameStarted == true)
        {
            Time.timeScale = 1;
        }
    }
}
