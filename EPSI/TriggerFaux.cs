using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerFaux : MonoBehaviour
{
    AudioSource aSource;
    public Text TriggerEPSI2V3;

    // This string will track which trigger the player is in (for wrong answers)
    private string currentTrigger = "";

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        // If the player enters a specific trigger, update the current trigger
        if (this.gameObject.tag == "TriggerEPSI2V3")
        {
            currentTrigger = "TriggerEPSI2V3";
        }
        else if (this.gameObject.tag == "TriggerEPSI3V3")
        {
            currentTrigger = "TriggerEPSI3V3";
        }
        else if (this.gameObject.tag == "TriggerEPSI4V3")
        {
            currentTrigger = "TriggerEPSI4V3";
        }
        else if (this.gameObject.tag == "TriggerEPSI5V3")
        {
            currentTrigger = "TriggerEPSI5V3";
        }
        else if (this.gameObject.tag == "TriggerEPSI6V3")
        {
            currentTrigger = "TriggerEPSI6V3";
        }
    }

    void OnTriggerExit(Collider collider)
    {
        // When exiting a trigger, reset the current trigger
        if (this.gameObject.tag == currentTrigger)
        {
            currentTrigger = "";  // Reset current trigger
        }
    }

    void Update()
    {
        // Check which trigger the player is inside and handle wrong answers accordingly
        if (currentTrigger == "TriggerEPSI2V3")
        {
            if (Input.GetKeyDown(KeyCode.O) || Input.GetKeyDown(KeyCode.U)) // Wrong answers for TriggerEPSI2V3
            {
                aSource.Play();
            }
        }
        else if (currentTrigger == "TriggerEPSI3V3")
        {
            if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.O)) // Wrong answers for TriggerEPSI3V3
            {
                aSource.Play();
            }
        }
        else if (currentTrigger == "TriggerEPSI4V3")
        {
            if (Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.I)) // Wrong answers for TriggerEPSI4V3
            {
                aSource.Play();
            }
        }
        else if (currentTrigger == "TriggerEPSI5V3")
        {
            if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.O)) // Wrong answers for TriggerEPSI5V3
            {
                aSource.Play();
            }
        }
        else if (currentTrigger == "TriggerEPSI6V3")
        {
            if (Input.GetKeyDown(KeyCode.U) || Input.GetKeyDown(KeyCode.O)) // Wrong answers for TriggerEPSI6V3
            {
                aSource.Play();
            }
        }
    }
}
