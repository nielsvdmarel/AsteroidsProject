using UnityEngine;
using System.Collections;

public class shieldAddon : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<PlayerRespawnScript>().shield = true;
        }

    }

}