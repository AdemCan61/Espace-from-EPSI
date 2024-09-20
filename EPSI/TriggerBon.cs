using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBon : MonoBehaviour
{
    AudioSource aSource;
    public Text TriggerEPSI2V2;
    public Text TriggerEPSI2V2Quest;

    // This string will track which trigger the player is in
    private string currentTrigger = "";

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        // If the player enters a specific trigger, update the current trigger
        if (this.gameObject.tag == "TriggerEPSI2V2")
        {
            currentTrigger = "TriggerEPSI2V2";
        }
        else if (this.gameObject.tag == "TriggerEPSI3V2")
        {
            currentTrigger = "TriggerEPSI3V2";
        }
        else if (this.gameObject.tag == "TriggerEPSI4V2")
        {
            currentTrigger = "TriggerEPSI4V2";
        }
        else if (this.gameObject.tag == "TriggerEPSI5V2")
        {
            currentTrigger = "TriggerEPSI5V2";
        }
        else if (this.gameObject.tag == "TriggerEPSI6V2")
        {
            currentTrigger = "TriggerEPSI6V2";
        }
    }

    void OnTriggerExit(Collider collider)
    {
        // When exiting a trigger, reset the current trigger and pause the audio
        if (this.gameObject.tag == currentTrigger)
        {
            currentTrigger = "";  // Reset current trigger
            aSource.Pause();
            TriggerEPSI2V2.text = "";
        }
    }

    void Update()
    {
        // Check which trigger the player is inside and handle input accordingly
        if (currentTrigger == "TriggerEPSI2V2")
        {
            if (Input.GetKeyDown(KeyCode.I)) // Correct answer for TriggerEPSI2V2
            {
                TriggerEPSI2V2Quest.text = "- Prenez un café et passez votre prochain examen.";
                aSource.Play();
            }
        }
        if (currentTrigger == "TriggerEPSI3V2")
        {
            if (Input.GetKeyDown(KeyCode.U)) // Correct answer for TriggerEPSI3V2
            {
                TriggerEPSI2V2Quest.text = "- Connectez les câbles et passez à l'examen suivant.";
                aSource.Play();
            }
        }
        if (currentTrigger == "TriggerEPSI4V2")
        {
            if (Input.GetKeyDown(KeyCode.O)) // Correct answer for TriggerEPSI3V2
            {
                TriggerEPSI2V2Quest.text = "- Parlez à vos amis et passez l'examen suivant.";
                aSource.Play();
            }
        }
        
        if (currentTrigger == "TriggerEPSI5V2")
        {
            if (Input.GetKeyDown(KeyCode.U)) // Correct answer for TriggerEPSI3V2
            {
                TriggerEPSI2V2Quest.text = "- Effectuer le travail de groupe et terminer l'examen.";
                aSource.Play();
            }
        }
        
        if (currentTrigger == "TriggerEPSI6V2")
        {
            if (Input.GetKeyDown(KeyCode.I)) // Correct answer for TriggerEPSI3V2
            {
                TriggerEPSI2V2Quest.text = "- Parlez avec la Secreter pour sortir de l'EPSI.";
                aSource.Play();
            }
        }
    }
}
