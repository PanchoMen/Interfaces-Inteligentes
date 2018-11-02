using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poder : MonoBehaviour {

    public GameObject jugador;
    public Text poder;
    private string title;

	// Use this for initialization
	void Start () {
        title = "Poder: ";
        jugador = GameObject.FindWithTag("Player");
        gameObject.GetComponent<Text>().text = (title + jugador.GetComponent<Colisiones>().poder.ToString());

    }
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = (title + jugador.GetComponent<Colisiones>().poder.ToString());

    }
}
