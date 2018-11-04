using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public delegate void linterna();
    public delegate void actualizar();

    public static GameController controlador;

    public linterna Encender;
    public actualizar Actualizacion;

    delegate void Controller();
    Controller controller;

    private void Awake() {
        if(controlador == null) {
            controlador = this;
            DontDestroyOnLoad(this);
        } else if(controlador != this) {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Actualizacion();
        if (Input.GetKeyUp(KeyCode.L))
        {
            Encender();
        }
    }
}
