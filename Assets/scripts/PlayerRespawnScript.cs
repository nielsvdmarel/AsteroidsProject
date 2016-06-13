using UnityEngine;
using System.Collections;

public class PlayerRespawnScript : MonoBehaviour
{

    public Vector2 spawn;

    private Rigidbody2D playerRigidbody;

    public bool shield;

    void Start()
    {




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
                }
                playerRigidbody.velocity = Vector2.zero;
                //print("collision found");
                this.transform.position = spawn;
            }
            else
            {
                shield = false;
            }
        }

    }

}
    


