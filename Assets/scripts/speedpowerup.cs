using UnityEngine;
using System.Collections;

public class speedpowerup : MonoBehaviour
{

    public float Speeed;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            speedup(Speeed);
            Destroy(gameObject);
            GameObject.Find("TextTimer").GetComponent<MyTimer>().resetTimer();
            GameObject.Find("TextTimer").GetComponent<MyTimer>().StartTimer();  

        }

    }

    public void speedup(float speedchange)
    {
        GameObject.Find("Player").GetComponent<PlayerMovementAst>().ThrustForce += speedchange;
    }

}