using UnityEngine;
using System.Collections;

public class laserscript : MonoBehaviour {

    public GameObject laser;
        private GameObject player = GameObject.Find("Player");

    private int staticLaserLength;

    void Start () {

         int laserlengt = GameObject.Find("muzzlepoint").GetComponent<laserShooting>().laserlengtget();
        Transform playerT = GameObject.Find("Player").transform;
        Quaternion playerRotation = GameObject.Find("Player").transform.rotation;

        staticLaserLength = laserlengt;

        this.transform.parent = GameObject.Find("Player").transform;
        GameObject.Find("Player").transform.rotation = new Quaternion(0, 0, 0, 0);
        this.transform.rotation = new Quaternion(playerT.rotation.x, playerT.rotation.y, playerT.rotation.z, playerT.rotation.w);
        this.transform.position = new Vector2(playerT.position.x, playerT.position.y);
        this.transform.position = new Vector2(playerT.position.x, playerT.position.y + 2 * staticLaserLength);
        GameObject.Find("Player").transform.rotation = playerRotation;
        //this.transform.position = new Vector2(playerT.position.x , playerT.position.y);
        if(laserlengt < 50)
        {
            //GameObject.Find("muzzlepoint").GetComponent<laserShooting>().instantiateLaser();
        }
    }
	
	void Update () {
        
    }

    public int getStaticLaser()
    {
        return staticLaserLength;
    }

    public void destroyLaser()
    {
        
            Destroy(gameObject);
        
    }
}
