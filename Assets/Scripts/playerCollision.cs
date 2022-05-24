using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "deathWall" )
        {
            transform.position = new Vector3(-2, 3, -2);
            transform.Rotate(0,0,0);
        }
        
    }

}
