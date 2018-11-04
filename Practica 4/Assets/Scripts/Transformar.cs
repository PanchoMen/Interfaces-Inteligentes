using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformar : MonoBehaviour {


    public float contador;
    public bool fin;
    private Renderer color;
    private Material inicial;

    // Use this for initialization
    void Start () {
        fin = true;
        color = gameObject.GetComponent<Renderer>();
        inicial = color.material;
    }

    // Update is called once per frame
    void Update()
    {
        Contador();
    }

    void CambiaColor(){
        color.material.SetColor("_Color", new Color(1, 0, 0, 1));
    }

    void Contador()
    {
        if (fin == false)
        {
            contador -= Time.deltaTime;
            if (contador < 0)
            {
                fin = true;
                contador = 30.0f;
                color.material = inicial;
            }
        }
    }
}
