using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicEPSI : MonoBehaviour
{
    AudioSource Dialogue;
    public AudioClip firstMusic;
    public AudioClip secondMusic;
    private bool hasExited = false;
    private bool isFirstMusicPlayed = false;

    void Start()
    {
        Dialogue = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider collider)
    {
        if (this.gameObject.tag == "TriggerDialogScreter")
        {
            if (!isFirstMusicPlayed)
            {
                Dialogue.clip = firstMusic;
                isFirstMusicPlayed = true;
                hasExited = false;
            }
            else if (hasExited)
            {
                Dialogue.clip = secondMusic;
                hasExited = false;
            }
            Dialogue.loop = false;
            Dialogue.Play();
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (this.gameObject.tag == "TriggerDialogScreter")
        {
            Dialogue.Stop();
            hasExited = true;
        }
    }
}
