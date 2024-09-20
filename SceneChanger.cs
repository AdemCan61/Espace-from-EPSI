using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string scenename;

    void OnTriggerEnter(Collider collider){
        if (this.gameObject.tag == "TriggerCapsule"){
            SceneManager.LoadScene(scenename);
        }
    }
}
