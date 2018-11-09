using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoA : MonoBehaviour
{

    // Use this for initialization
    void Start() {
        GameController.controlador.CambiarTamano += CambiarTamanio;
    }

    // Update is called once per frame
    void Update(){ }

    private void OnCollisionEnter(Collision collision)
    {
        //Aumentar poder a los objetos B y cambiar color
        GameController.controlador.ColTipoA();
    }

    void CambiarTamanio(float tam){
        Debug.Log("Cambiando Tamaño");
        gameObject.GetComponent<Transform>().localScale += new Vector3(tam, tam, tam);
    }
}
