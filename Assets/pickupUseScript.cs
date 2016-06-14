using UnityEngine;
using System.Collections;

public class pickupUseScript : MonoBehaviour {

    private bool laser;
    private bool speed;
    private bool LaserSelected;
    private float speednum;
    private bool haveAPickup;


    void Start () {
        laser = false;
        speed = false;
        LaserSelected = false;

    }
	
	// Update is called once per frame
	void Update () {
        print(LaserSelected);
        if (Input.GetMouseButtonDown(1))
        {
            if(laser && LaserSelected)
            {
                GameObject.Find("muzzlepoint").GetComponent<laserShooting>().laserStart();
                laser = false;
            }
            else if(speed && !LaserSelected)
            {
                GameObject.Find("TextTimer").GetComponent<MyTimer>().resetTimer();
                GameObject.Find("TextTimer").GetComponent<MyTimer>().StartTimer();
                speedup(speednum);
                speed = false;
            }
            
            
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0 || Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            LaserSelected = !LaserSelected;
        }
        booleanChecks();


    }

    public void makeLaserTrue()
    {
        laser = true;
    }
    public void makeSpeedTrue()
    {
        speed = true;
    }
    public void setSpeed(float Speeed)
    {
        speednum = Speeed;
    }
    public bool getSpeed()
    {
        return speed;
    }
    public bool getLaser()
    {
        return laser;
    }
    public bool getSelected()
    {
        return LaserSelected;
    }
    public bool gethave()
    {
        return haveAPickup;
    }
    private void speedup(float speedchange)
    {
        GameObject.Find("Player").GetComponent<PlayerMovementAst>().ThrustForce += speedchange;
    }
    private void booleanChecks()
    {
        if (laser && !speed)
        {
            LaserSelected = true;
        }
        else if (!laser && speed)
        {
            LaserSelected = false;
        }
        if (!speed && !laser)
        {
            haveAPickup = false;
        }
        else
        {
            haveAPickup = true;
        }
    }
}
