using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoB : MonoBehaviour {


    public float contador;
    public bool fin;
    private Renderer color;
    private Color inicial;

    // Use this for initialization
    void Start () {
        contador = 10.0f;
        fin = true;
        GameController.controlador.ColisionTipoB += Actualizar;
        color = gameObject.GetComponent<Renderer>();
        inicial = color.material.color;
    }

    // Update is called once per frame
    void Update() {
        Contador();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (fin) {
            GameController.controlador.poder -= 10;
        } else {
            GameController.controlador.poder -= 20;
        }
        GameController.controlador.ColTipoB();
    }

    void CambiaColor() {
        color.material.SetColor("_Color", new Color(1, 0, 0, 1));
        fin = false;
    }

    void Actualizar() {
        CambiaColor();
        contador = 10.0f;
    }

    void Contador() {
        if (fin == false){
            contador -= Time.deltaTime;
            if (contador < 0) {
                fin = true;
                contador = 10.0f;
                color.material.SetColor("_Color", inicial);
            }
        }
    }

}
