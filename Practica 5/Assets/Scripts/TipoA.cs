using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoA : MonoBehaviour
{
    public Renderer color;
    public Color RColor;

    // Use this for initialization
    void Start() {
        color = gameObject.GetComponent<Renderer>();
        GameController.controlador.ColisionTipoA += CambiaColor;

    }

    // Update is called once per frame
    void Update(){ }

    private void OnCollisionEnter(Collision collision)
    {
        //Si A colisiona con C:
            //los objetos C aumentan el tamaño y los objeto A cambian de color
        if (collision.gameObject.CompareTag("TipoC"))
        {
            GameController.controlador.ColTipoAC();
        }

    }

    void CambiaColor(Color color_)
    {
        RColor = color_;
        Debug.Log("ESTOY CAMBIANDO DE COLOR");
        // Aplica el color especificado
        color.material.color = color_;
    }


}
