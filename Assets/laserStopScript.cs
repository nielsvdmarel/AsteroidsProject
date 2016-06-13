using UnityEngine;
using System.Collections;

public class laserStopScript : MonoBehaviour {
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "laser")
        {
            int laserNumber = other.GetComponent<laserscript>().staticLaserLength;
            GameObject[] lasers = GameObject.FindGameObjectsWithTag("laser");
            
            for (int i = 0; i < lasers.Length; i++)
            {
                if (lasers[i].GetComponent<laserscript>().staticLaserLength > laserNumber)
                {
                    //print("hisers");
                    Destroy(lasers[i]);
                    GameObject.Find("muzzlepoint").GetComponent<laserShooting>().LaserCounterEq(laserNumber);
                }
            }
        }

    }
}
