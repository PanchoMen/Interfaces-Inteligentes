using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public delegate void DelegadoEventos();
public delegate void DelegadoTamano(float tamano);
public delegate void DelegadoColor(Color color);

public class GameController : MonoBehaviour {

    public int poder;

    private string title;

    public static GameController controlador;

    public event DelegadoEventos Encender;
    public event DelegadoColor ColisionTipoA;
    public event DelegadoColor Boton;
    public event DelegadoTamano CambiarTamano;

    private void Awake() {
        if(controlador == null) {
            controlador = this;
            DontDestroyOnLoad(this);
        } else if(controlador != this) {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        poder = 100;

        title = "Poder Objetos B: ";
        GameObject.Find("Poder").GetComponent<Text>().text = (title + poder);
    }

    // Update is called once per frame
    void Update()
    {

        Mensajepoder();

        Linterna();
    }

    void Mensajepoder(){
        GameObject.Find("Poder").GetComponent<Text>().text = (title + poder);
    }

    void Linterna(){
        if (Input.GetKeyUp(KeyCode.L))
        {
            Encender();
        }
    }

    public void ColTipoAC(){
        ColisionTipoA(new Color(Random.value, Random.value, Random.value));
        CambiarTamano(0.2f);
        poder += 10;
    }

    public void PressButton(){
        Debug.Log("BOTON PULSADO");
        Boton(new Color(Random.value, Random.value, Random.value));
    }
}
