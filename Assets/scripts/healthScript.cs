﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class healthScript : MonoBehaviour {

    public float maxHealth;
    public float minHealth;
    public bool boss;
    public GameObject enemies;
    public GameObject drone;
    public float dronehealthloss;

    private float dronespawnhealth;
    private GameObject[] droneSpawned;
    

    public float currentHealth;
	
	void Start () {
        enemies = GameObject.Find("enemies");
        currentHealth = maxHealth;
        //Destroy(gameObject);
    }

    void Update () {
        if (!boss)
        {
            if (currentHealth < minHealth)
            {
                enemies.GetComponent<waveScript>().enemmiesDiedPlus();
                Destroy(gameObject);
            }
        }
        else if (boss)
        {

            if( currentHealth < maxHealth / 4 * 3 && currentHealth > maxHealth / 2)
            {
                targetPlayer();
            }
            if (currentHealth < maxHealth / 2 - dronespawnhealth && currentHealth > maxHealth / 4)
            {
                spawnDrones(4);
                dronespawnhealth += dronehealthloss;
            }
            if(currentHealth < maxHealth / 4 && currentHealth > minHealth)
            {
                targetMoederboord();
            }
            if (currentHealth < minHealth)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Win");
            }
        }
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet") {
            Destroy(other.gameObject);
            currentHealth -= other.GetComponent<bulletCollision>().damage;
        }
        if (other.tag == "laser")
        {
            Destroy(gameObject);
        }
    }
    private void targetPlayer()
    {
        this.GetComponent<EnemyMovement>().setTarget(GameObject.Find("Player").transform);
        //this.GetComponent<EnemyMovement>().forward = true;
        this.GetComponent<EnemyfaceM>().target = GameObject.Find("Player");
    }
    private void targetMoederboord()
    {
        this.GetComponent<EnemyMovement>().setTarget(GameObject.Find("MoederBoord").transform);
        this.GetComponent<EnemyfaceM>().target = GameObject.Find("MoederBoord");
    }
    private void spawnDrones(int AmountOfDrones)
    {
        for (int i = 0; i < AmountOfDrones; i++)
        {
            int droneNumber = i;
            if(droneNumber > 3)
            {
                droneNumber = droneNumber % 4;
            }
            Instantiate(drone).GetComponent<EnemyMovement>().setDroneNumber(droneNumber);
        }
    }

}
