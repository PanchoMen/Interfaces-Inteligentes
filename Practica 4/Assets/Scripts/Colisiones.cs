using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{

    public int poder;
    public float contador;
    public bool fin;
    private GameObject decrementos;
    private Renderer color;
    private Material inicial;

    // Use this for initialization
    void Start()
    {
        poder = 100;
        contador = 30.0f;
        fin = true;
        decrementos = GameObject.FindWithTag("Decremento");
        color = decrementos.GetComponent<Renderer>();
        inicial = color.material;
    }

    // Update is called once per frame
    void Update(){
        Contador();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Incremento")
        {
            poder += 10;
        }
        if (collision.gameObject.tag == "Decremento")
        {
            poder -= 10;
            fin = false;
            Transformar();
        }
    }

    void Contador(){
        if (fin == false) {
            contador -= Time.deltaTime;
            if (contador < 0) {
                fin = true;
                contador = 30.0f;
                color.material = inicial;
            }
        }
    }

    void Transformar(){
        color.material.SetColor("_Color", new Color(1, 0, 0, 1));
    }
}
