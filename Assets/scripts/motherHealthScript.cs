using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class motherHealthScript : MonoBehaviour
{

    public float maxHealth;
    public float minHealth;

    public float currentHealth;

    // Use this for initialization
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

        if (currentHealth < minHealth)
        {
            Destroy(gameObject);



            SceneManager.LoadScene("gameover");


        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "enemy")
        {

            //other.GetComponent<EnemyMovement>.forward = false;
            other.GetComponentInParent<EnemyMovement>().forward = false;
            other.GetComponentInParent<EnemyMovement>().setrange();
            currentHealth -= other.GetComponent<motherDamageScript>().Motherdamage;
        }
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<EdgeCollider2D>().isTrigger = false;
        }
    }
}
