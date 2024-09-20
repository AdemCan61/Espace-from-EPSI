using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggersSubEPSI : MonoBehaviour
{
    // Start is called before the first frame update

    public Text TriggerSubEPSI;
    public Text TriggerEPSI2;
    void Start()
    {
        TriggerSubEPSI.text = "Maximo : AAAAAAAAAAAAAAAHHHHHH!!!";
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (this.gameObject.tag == "TriggerDialogScreter"){
            TriggerSubEPSI.text = "Maximo : Bonjour, où est-ce que je suis? Comment je peux sortir de là ?";
        }   
        if (this.gameObject.tag == "TriggerEPSI2"){
            TriggerEPSI2.text = "Quel élément HTML est utilisé pour créer un lien hypertexte ?";
        }
        if (this.gameObject.tag == "TriggerEPSI3"){
            TriggerEPSI2.text = "Comment change t'on la taille de la police d'un texte en CSS ?";
        }
        if (this.gameObject.tag == "TriggerEPSI4"){
            TriggerEPSI2.text = "Quel langage est principalement utilisé pour interagir avec une base de données relationnelle ?";
        }
        if (this.gameObject.tag == "TriggerEPSI5"){
            TriggerEPSI2.text = "Quel est l'objectif principal d'une analyse SWOT en marketing ?";
        }
        if (this.gameObject.tag == "TriggerEPSI6"){
            TriggerEPSI2.text = "Comment commente-t-on une ligne de code en Python ?";
        }
    }
}