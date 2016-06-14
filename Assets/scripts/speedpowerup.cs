using UnityEngine;
using System.Collections;

public class speedpowerup : MonoBehaviour
{

    public float Speeed;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<pickupUseScript>().makeSpeedTrue();
            other.GetComponent<pickupUseScript>().setSpeed(Speeed);
            Destroy(gameObject);
             

        }

    }

    public void speedup(float speedchange)
    {
        GameObject.Find("Player").GetComponent<PlayerMovementAst>().ThrustForce += speedchange;
    }

}