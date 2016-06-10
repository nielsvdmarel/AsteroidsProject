using UnityEngine;
using System.Collections;

public class laserShooting : MonoBehaviour {

    public GameObject headLaser;

    private int laserCounter;
    private int totallaserAmount = 0;
    private bool deleteLaser = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.V))
        {
            // instantiateLaser();
            totallaserAmount += 50;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            deleteLaser = true;
        }

        if(laserCounter < totallaserAmount)
        {
            instantiateLaser();
        }

        if (deleteLaser)
        {
            Destroy(GameObject.FindGameObjectsWithTag("laser")[laserCounter-1]);
            totallaserAmount = 0;
            laserCounter--;
            if(laserCounter == 0)
            {
                deleteLaser = false;
            }
        }

    }

    public int laserlengtget()
    {
        return laserCounter;
    }
    public void instantiateLaser()
    {
        Instantiate(headLaser);
        laserCounter++;
    }
}
