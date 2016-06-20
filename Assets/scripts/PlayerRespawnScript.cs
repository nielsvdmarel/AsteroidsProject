﻿using UnityEngine;
using System.Collections;

public class PlayerRespawnScript : MonoBehaviour
{

    public Vector2 spawn;

    private Rigidbody2D playerRigidbody;

    public bool shield;

    public AudioClip playerDieClip;

    private AudioSource audioSourceComponent;
    void Start()
    {
        audioSourceComponent = this.GetComponent<AudioSource>();



        playerRigidbody = this.GetComponent<Rigidbody2D>();
        if (spawn.x == 0 && spawn.y == 0)
        {
            spawn = GameObject.Find("MoederBoord").transform.position;
            this.GetComponent<Collider2D>().isTrigger = true;
        }
        this.transform.position = spawn;

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "enemy")
        {
            if (!shield) {
                if (spawn.x == GameObject.Find("MoederBoord").transform.position.x && spawn.y == GameObject.Find("MoederBoord").transform.position.y)
                {
                    this.GetComponent<Collider2D>().isTrigger = true;
                    audioSourceComponent.PlayOneShot(playerDieClip, 1F);
                    
                }
                playerRigidbody.velocity = Vector2.zero;
                //print("collision found");
                this.transform.position = spawn;
            }
            else
            {
                shield = false;
                GameObject.Find("shield").GetComponent<shieldScript>().shield = false;
            }
        }

    }

}
    


