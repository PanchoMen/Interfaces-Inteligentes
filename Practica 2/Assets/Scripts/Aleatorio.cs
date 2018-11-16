using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aleatorio : MonoBehaviour {

    public float moveSpeed = 20f;
    public float turnSpeed = 50f;
    public int direccion = 0;
    public float moveTime = 0;

	// Use this for initialization
	void Start () {
        ActualizarDireccion();
    }
	
	// Update is called once per frame
	void Update () {
        if (moveTime <= 0) {
            ActualizarDireccion();
        } else {
            Mover();
            moveTime -= Time.deltaTime;
        }
	}

    void ActualizarDireccion() {
        direccion = Random.Range(0, 4);
        switch (direccion) {
            case 1:
            case 3:
                moveTime = Random.Range(1, 2);
                break;
            case 2:
            case 4:
                moveTime = Random.Range(5, 10);
                break;
        }
    }

    void Mover() {
        switch (direccion){
            case 0: //ARRIBA
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                break;
            case 1: //IZQUIERDA
                transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
                break;
            case 2: //ABAJO
                transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
                break;
            case 3: //DERECHA
                transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
                break;
        }
    }
}
