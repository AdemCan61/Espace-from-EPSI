using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outro : MonoBehaviour
{
    float b;

    void Start()
    {
        b = 0;
    }

    void Update()
    {
        b += 1 * Time.deltaTime;
        if (b > 64)
        {
            QuitGame();
            b = 0;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            b = 64;
        }
    }

    void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
