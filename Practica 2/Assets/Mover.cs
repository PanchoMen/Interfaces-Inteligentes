using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float moveSpeed = 20f;
    public float turnSpeed = 50f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.I)) {
            //ARRIBA
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L)){
            //DERECHA
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.K)){
            //ABAJO
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.J)){
            //IZQUIERDA
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

    }
}
