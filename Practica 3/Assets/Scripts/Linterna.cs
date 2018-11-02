using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour {

    Light linterna;

    // Use this for initialization
    void Start () {
        linterna = gameObject.GetComponent<Light>();

    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.L)){
            OnOff();
        }
	}

    void OnOff(){
        if (linterna.enabled == true) {
            linterna.enabled = false;
        } else {
            linterna.enabled = true;
        }
    }
}
