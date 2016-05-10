using UnityEngine;
using System.Collections;

public class healthScript : MonoBehaviour {

    public float maxHealth;
    public float minHealth;

    public float currentHealth;
	
	void Start () {
        currentHealth = maxHealth;
        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
	if (currentHealth < minHealth)
        {
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet") { 
        Destroy(other.gameObject);
        currentHealth -= other.GetComponent<bulletCollision>().damage;
        }
    }

}
