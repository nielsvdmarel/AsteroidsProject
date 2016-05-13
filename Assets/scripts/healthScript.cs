using UnityEngine;
using System.Collections;

public class healthScript : MonoBehaviour {

    public float maxHealth;
    public float minHealth;
    public GameObject enemies;
    

    public float currentHealth;
	
	void Start () {
        enemies = GameObject.Find("enemies");
        currentHealth = maxHealth;
        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update () {
	if (currentHealth < minHealth)
        {
            enemies.GetComponent<waveScript>().enemiesDied += 1;
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
