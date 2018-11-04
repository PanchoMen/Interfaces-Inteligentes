using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoA : MonoBehaviour
{

    // Use this for initialization
    void Start() { }

    // Update is called once per frame
    void Update(){ }

    private void OnCollisionEnter(Collision collision)
    {
        GameController.controlador.poder += 10;
    }
}
