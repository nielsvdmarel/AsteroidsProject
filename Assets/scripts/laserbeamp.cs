using UnityEngine;
using System.Collections;

public class laserbeamp : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("muzzlepoint").GetComponent<laserShooting>().laserStart();
        }

    }
}