using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggersEPSI : MonoBehaviour
{
    public Text TriggerEPSI;
    void OnTriggerEnter(Collider collider)
    {
        if (this.gameObject.tag == "TriggerEPSI"){
            TriggerEPSI.text = "- Parlez avec la Dame.";
        }
        if (this.gameObject.tag == "TriggerEPSI1"){
            TriggerEPSI.text = "- Parlez avec le Professeur qui se situe dans la sale Bleu.";
        }
        if (this.gameObject.tag == "TriggerEPSI2"){
            TriggerEPSI.text = "- Passez votre premier examen.";
        }
        if (this.gameObject.tag == "TriggerEPSI3"){
            TriggerEPSI.text = "- Passez votre second examen.";
        }
        if (this.gameObject.tag == "TriggerEPSI4"){
            TriggerEPSI.text = "- Passez votre troisieme examen.";
        }
        if (this.gameObject.tag == "TriggerEPSI5"){
            TriggerEPSI.text = "- Passez votre quatrieme examen.";
        }
        if (this.gameObject.tag == "TriggerEPSI6"){
            TriggerEPSI.text = "- Passez votre cinqieme examen.";
        }
    }
}
