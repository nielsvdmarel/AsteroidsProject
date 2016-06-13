using UnityEngine;
using System.Collections;

public class motherHealthUp : MonoBehaviour
{
    public bool procent;
    public float amount;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Destroy(gameObject);
            float motherHealth = GameObject.Find("MoederBoord").GetComponent<motherHealthScript>().currentHealth;
            float motherMaxHealth = GameObject.Find("MoederBoord").GetComponent<motherHealthScript>().maxHealth;
            if (procent)
            {
                GameObject.Find("MoederBoord").GetComponent<motherHealthScript>().currentHealth += motherMaxHealth / 100 * amount;
            }
            else
            {
                GameObject.Find("MoederBoord").GetComponent<motherHealthScript>().currentHealth += amount;
            }

        }


    }
}
