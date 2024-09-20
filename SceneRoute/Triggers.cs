using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggers : MonoBehaviour
{
    public Text Trigger;
    void Start()
    {
        Trigger.text = "- Avancer jusqu'à la première porte.";
    }
    void OnTriggerEnter(Collider collider)
    {
        if (this.gameObject.tag == "TriggerEPSI"){
            Trigger.text = "- Parlez avec la Dame.";
        }
    }
}
