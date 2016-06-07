using UnityEngine;
using System.Collections;

public class laserShooting : MonoBehaviour {

    public GameObject headLaser;

    private int laserCounter;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.V))
        {
            Instantiate(headLaser);
            laserCounter++;
        }

    }

    public int laserlengtget()
    {
        return laserCounter;
    }
}
