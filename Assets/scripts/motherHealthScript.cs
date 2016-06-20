﻿using UnityEngine;
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
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth < minHealth)
        {
            Destroy(gameObject);



            // SceneManager.LoadScene("gameover");
            GameObject.Find("Audio Source").GetComponent<backgroudSound>().clip = 2;
            GameObject.Find("Audio Source").GetComponent<backgroudSound>().win = false;

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "enemy")
        {
            currentHealth -= other.GetComponent<motherDamageScript>().Motherdamage;
            //other.GetComponent<EnemyMovement>.forward = false;
            other.GetComponentInParent<EnemyMovement>().forward = false;
            other.GetComponentInParent<EnemyMovement>().setrange();
            
            if (other.GetComponentInParent<EnemyMovement>().drone)
            {
                Destroy(other.gameObject);
            }
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
            other.GetComponent<Collider2D>().isTrigger = false;
        }
    }
}
