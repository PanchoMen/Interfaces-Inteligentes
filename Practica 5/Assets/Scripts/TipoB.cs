using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoB : MonoBehaviour {

    public Renderer color;

    // Use this for initialization
    void Start () {
        color = gameObject.GetComponent<Renderer>();
        GameController.controlador.Boton += CambiaColor;
    }

    // Update is called once per frame
    void Update() {

    }

    void CambiaColor(Color color_)
    {
        Debug.Log("ESTOY CAMBIANDO DE COLOR");
        // Aplica el color especificado
        color.material.color = color_;
    }


}
