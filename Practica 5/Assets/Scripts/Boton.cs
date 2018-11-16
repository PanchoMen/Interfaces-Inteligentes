using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour {

    public Button colorBTN;

    // Use this for initialization
    void Start ()
    {
        colorBTN.onClick.AddListener(GameController.controlador.PressButton);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
