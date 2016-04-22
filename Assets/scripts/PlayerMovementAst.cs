using UnityEngine;
using System.Collections;

public class PlayerMovementAst : MonoBehaviour {

    public float RotationSpeed;
    public float ThrustForce;
    
    private Rigidbody2D myScriptsRigidbody2D;

    void Start ()
    {
	 
	}

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.A))
        {
            myScriptsRigidbody2D = GetComponent<Rigidbody2D>();
            myScriptsRigidbody2D.angularVelocity = RotationSpeed;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            myScriptsRigidbody2D = GetComponent<Rigidbody2D>();
            myScriptsRigidbody2D.angularVelocity = -RotationSpeed;
        }

        else
        {
            myScriptsRigidbody2D.angularVelocity = 0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            myScriptsRigidbody2D.AddForce(transform.up * ThrustForce);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            myScriptsRigidbody2D.AddForce(transform.up * -ThrustForce);

        }




    }
}
