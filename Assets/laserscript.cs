using UnityEngine;
using System.Collections;

public class laserscript : MonoBehaviour {

    public GameObject laser;

	// Use this for initialization
	void Start () {



        GameObject player = GameObject.Find("Player");
        this.transform.parent = player.transform;
        this.transform.position = new Vector2(0,0);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
