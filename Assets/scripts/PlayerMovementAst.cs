using UnityEngine;
using System.Collections;

public class PlayerMovementAst : MonoBehaviour {

    public float RotationSpeed;
    public float ThrustForce;
    public float defaultspeed;

    public float breakforce;
    
    private Rigidbody2D Rigidbody2D;

    void Start ()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        defaultspeed = ThrustForce;
    }

    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (GameObject.Find("enemies").GetComponent<waveScript>().playercanmove)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {

                //Rigidbody2D.angularVelocity = RotationSpeed;
                Rigidbody2D.AddForce(transform.right * -ThrustForce);
            }

            else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {

                //Rigidbody2D.angularVelocity = -RotationSpeed;
                Rigidbody2D.AddForce(transform.right * ThrustForce);
            }
            else
            {
                Rigidbody2D.angularVelocity = 0f;
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {

                Rigidbody2D.AddForce(transform.up * ThrustForce);

            }

            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {

                Rigidbody2D.AddForce(transform.up * -ThrustForce);


            }

            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightControl))
            {

                Rigidbody2D.velocity = new Vector2(Rigidbody2D.velocity.x / breakforce, Rigidbody2D.velocity.y / breakforce);


            }

        }


    }
}
