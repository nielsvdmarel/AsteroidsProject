using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    private Transform target;
    public float speed = 2f;
    public float backSpeed = 1f;
    public float bounceDistance;
    public float spawnDistance;
    public bool drone;

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
            motherboard = GameObject.Find("MoederBoord");
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
        range = Vector2.Distance(transform.position, target.position);

        if(range > rangeSet + bounceDistance)
            forward = true;


            if (forward == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, backSpeed * Time.deltaTime);
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
    private void Dronespawn()
    {
        string whichspawn = "DroneSpawn" + dronenum;
        this.transform.position = GameObject.Find(whichspawn).transform.position;
        this.transform.rotation = GameObject.Find(whichspawn).transform.rotation;
        motherboard = GameObject.Find("Player");
    }

}
