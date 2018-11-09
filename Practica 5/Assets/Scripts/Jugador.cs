using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

    public Light linterna;

	// Use this for initialization
	void Start () {

       //Inicializadores para la linterna
       GameController.controlador.Encender += OnOff;
    }
	
	// Update is called once per frame
	void Update () {

    }

   /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.Equals(GameObject.FindWithTag("Incremento"))){
            Debug.Log("He chocado");
            GameController.controlador.ColTipoA();
        }
        if (collision.Equals(GameObject.FindWithTag("Decremento")))
        {
            GameController.controlador.ColTipoB();
        }
    }*/

    public void OnOff()
    {
        if (linterna.enabled == true)
        {
            linterna.enabled = false;
        }
        else
        {
            linterna.enabled = true;
        }
    }
}
