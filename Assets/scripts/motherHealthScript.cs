using UnityEngine;
using System.Collections;

public class motherHealthScript : MonoBehaviour {

    public float maxHealth;
    public float minHealth;

    public float currentHealth;

    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
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
        //other.GetComponent<EnemyMovement>.forward = false;
        other.GetComponentInParent<EnemyMovement>().forward = false;
        other.GetComponentInParent<EnemyMovement>().setrange();
        currentHealth -= other.GetComponent<motherDamageScript>().Motherdamage;
    }
}
