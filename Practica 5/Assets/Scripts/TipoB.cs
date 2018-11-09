using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoB : MonoBehaviour {

    public Renderer color;
    public Color RColor;

    // Use this for initialization
    void Start () {
        color = gameObject.GetComponent<Renderer>();
        GameController.controlador.ColisionTipoA += CambiaColor;

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //Mueve los objetos C en funcion de su poder
        GameController.controlador.ColTipoB();
    }

    void CambiaColor() {
        Debug.Log("ESTOY CAMBIANDO DE COLOR");
        // Genera un color aleatorio y aplica el color generado
        RColor = new Color(Random.value, Random.value, Random.value);
        color.material.color = RColor;
    }
}
