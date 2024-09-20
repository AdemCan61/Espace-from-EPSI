using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    float a;
    void Start()
    {
        a=0;
    }

    // Update is called once per frame
    void Update()
    {
        a+=1*Time.deltaTime;
        if(a>69){
            SceneManager.LoadScene(1);
            a=0;
        }
        if (Input.GetKeyDown (KeyCode.Escape)){
            a = 69;
        }
    }
}
