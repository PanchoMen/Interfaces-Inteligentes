using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensores : MonoBehaviour {

    private Renderer color;
    private Color tono1 = new Color(1, 0, 0, 1);
    private Color tono2 = new Color(1, 0.1f, 0.1f, 1);
    private Color tono3 = new Color(1, 0.5f, 0.5f, 1);


    // Use this for initialization
    void Start () {
        color = GetComponent<Renderer>();
        color.material.SetColor("_Color", tono3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        color.material.SetColor("_Color", tono1);
    }

    private void OnCollisionStay(Collision collision)
    {
        color.material.SetColor("_Color", tono2);
    }

    private void OnCollisionExit(Collision collision)
    {
        color.material.SetColor("_Color", tono3);
    }
}
