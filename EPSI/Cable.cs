using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cable : MonoBehaviour
{
    AudioSource source;
    private bool isInsideTrigger = false;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = false;
        }
    }
    void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.F))
        {
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
    }
}
