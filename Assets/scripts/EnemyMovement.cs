using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private Transform target;
    public float speed = 2f;
    public float backSpeed = 1f;
    public float bounceDistance;
    public float spawnDistance;
    public bool drone;
    public bool stopMoving;

    public GameObject motherboard;
    private float minDistance = 1f;
    private float range;
    private float rangeSet;
    private int dronenum;
    

    public bool forward = false;


    
    void Start ()
    {
        
        if (!drone)
        {
            RandomSpawn();
        }
        else
        {
            Dronespawn();
        }
        
        target = motherboard.transform; 
        forward = true;
        backSpeed = -backSpeed;
    }
	
	
	void Update ()
    {
        if (!stopMoving) {

        
        range = Vector2.Distance(transform.position, target.position);

            //Debug.Log(range);
        if(range > rangeSet + bounceDistance){
            forward = true;
        }
            if (forward == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, backSpeed * Time.deltaTime);
            }
        }
    }

    public void setrange()
    {
        rangeSet = Vector2.Distance(transform.position, target.position);
    }
    public void setTarget(Transform tar)
    {
        target = tar;
    }
    public void setDroneNumber(int Dronenum)
    {
        print(Dronenum);
        dronenum = Dronenum + 1;
    }
    private void RandomSpawn()
    {
        if (spawnDistance == 0){ spawnDistance = GameObject.Find("enemies").GetComponent<waveScript>().spawndistance; }

            float random = Random.Range(0, 100);

            if (random< 25 && random> 0) { transform.position = new Vector2(Random.Range(spawnDistance, -spawnDistance), spawnDistance); }
            else if (random< 50 && random> 25) { transform.position = new Vector2(Random.Range(spawnDistance, -spawnDistance),-spawnDistance); }
            else if (random< 75 && random> 50) { transform.position = new Vector2(spawnDistance, Random.Range(spawnDistance, -spawnDistance)); }
            else if (random< 100 && random> 75) { transform.position = new Vector2(-spawnDistance, Random.Range(spawnDistance, -spawnDistance)); }

             motherboard = GameObject.Find("MoederBoord");
    }
    private void Dronespawn()
    {
        string whichspawn = "DroneSpawn" + dronenum;
        this.transform.position = GameObject.Find(whichspawn).transform.position;
        this.transform.rotation = GameObject.Find(whichspawn).transform.rotation;
        motherboard = GameObject.Find("Player");
    }

}
