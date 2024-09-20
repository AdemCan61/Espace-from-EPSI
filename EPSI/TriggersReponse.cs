using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TriggersReponse : MonoBehaviour
{
    AudioSource aSource;
    public Text TriggerEPSI2;

    // This boolean will track if the player is inside the trigger
    private bool isInsideTrigger = false;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        // If the player enters the trigger, update the UI and play the audio
        if (this.gameObject.tag == "TriggerEPSI2")
        {
            isInsideTrigger = true;  // Set flag to true
            TriggerEPSI2.text = "(U) <div> | (I) <a> | (O) <span>";
            aSource.Play();
        }
        if (this.gameObject.tag == "TriggerEPSI3")
        {
            isInsideTrigger = true;  // Set flag to true
            TriggerEPSI2.text = "(U) font-size | (I) text-size | (O) font-weight";
            aSource.Play();
        }
        if (this.gameObject.tag == "TriggerEPSI4")
        {
            isInsideTrigger = true;  // Set flag to true
            TriggerEPSI2.text = "(U) HTML | (I) JavaScript | (O) SQL";
            aSource.Play();
        }
        if (this.gameObject.tag == "TriggerEPSI5")
        {
            isInsideTrigger = true;  // Set flag to true
            TriggerEPSI2.text = "(U) Identifier les forces, faiblesses, opportunités et menaces d'une entreprise | (I) Définir le budget publicitaire | (O) Créer un logo de marque";
            aSource.Play();
        }
        if (this.gameObject.tag == "TriggerEPSI6")
        {
            isInsideTrigger = true;  // Set flag to true
            TriggerEPSI2.text = "(U) /* commentaire */ | (I) # commentaire | (O) <!-- commentaire -->";
            aSource.Play();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (this.gameObject.tag == "TriggerEPSI2")
        {
            isInsideTrigger = false;
        }
        if (this.gameObject.tag == "TriggerEPSI3")
        {
            isInsideTrigger = false;
        }
        if (this.gameObject.tag == "TriggerEPSI4")
        {
            isInsideTrigger = false;
        }
        if (this.gameObject.tag == "TriggerEPSI5")
        {
            isInsideTrigger = false;
        }
        if (this.gameObject.tag == "TriggerEPSI6")
        {
            isInsideTrigger = false;
        }
    }

    void Update()
    {
        if (isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.I))
            {     
                TriggerEPSI2.text = "";
            }
        }
    }
}
