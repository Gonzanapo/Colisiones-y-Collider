using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colission : MonoBehaviour {


    public GameObject plane;
    public GameObject cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision cube)
    {
        Debug.Log("Choque pa");
    }
    private void OnCollisionExit()
    {
        Debug.Log("Dejo de hacer contacto");
    }


}
    