using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoC : MonoBehaviour {

    public int direccion;
    //public Rigidbody rb;
    public Vector3 movement;

    // Use this for initialization
    void Start () {
        GameController.controlador.CambiarTamano += CambiarTamanio;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Si A colisiona con C:
        //los objetos C aumentan el tamaño y los objeto A cambian de color
        if (collision.gameObject.CompareTag("TipoA"))
        {
            GameController.controlador.ColTipoAC();
        }

    }

    void CambiarTamanio(float tam)
    {
        Debug.Log("Cambiando Tamaño");
        gameObject.GetComponent<Transform>().localScale += new Vector3(tam, tam, tam);
    }

    void mover()
    {
        Debug.Log("me he movido");
        direccion = Random.Range(0, 2);
        //Vector3 movement = new Vector3();
        switch (direccion)
        {
            case 0:
                movement = new Vector3(1.0f, 0, 0);
                break;
            case 1:
                movement = new Vector3(0, 0, 1.0f);
                break;
            case 2:
                movement = new Vector3(1.0f, 0, 1.0f);
                break;
        }
        transform.Translate(movement * (GameController.controlador.poder / 10));
    }
}
