using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionCounter : MonoBehaviour {

    public int contador = 0;
    private string mensaje = "";

    // Use this for initialization
    void Start()
    {
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Esfera"){
            //Renderer.material.color = Color.red;
            Debug.Log("He chocado");
            contador++;
            mensaje = "Contador: " + contador;
            Debug.Log(mensaje);
            //MostrarContador();
        } else {
            Debug.Log("Colisión no contemplada");
        }

    }

    /*private void MostrarContador(){
        GUI.Label(Rect (Screen.width/2,50,200,30), mensaje);
    }*/
}