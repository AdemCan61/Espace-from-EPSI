using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    AudioSource aSource;
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }
}
