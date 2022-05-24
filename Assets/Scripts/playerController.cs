using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float movementSpeed;
    public float rotationSpeed;
    public KeyCode left;
    public KeyCode right;
    public KeyCode up;
    public KeyCode down;
    public KeyCode rotate;
    public KeyCode invRotate;

    // Use this for initialization
    void Start () {
        movementSpeed = 0.1f;
        rotationSpeed = 4;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position += new Vector3(0, 0, movementSpeed);
        if (Input.GetKey(left))
        {
           transform.Translate (0, 0, movementSpeed);
        }
        if (Input.GetKey(right))
        {
           transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(up))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(down))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(rotate))
        {
            transform.Rotate(0, rotationSpeed, 0);
        }
        if (Input.GetKey(invRotate))
        {
            transform.Rotate(0, -rotationSpeed, 0);
        }
        

    }
}
