using UnityEngine;
using System.Collections;

public class MinimapFollowNoRotate : MonoBehaviour {

    public GameObject game2;

	// Use this for initialization
	void Start ()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    
     {
        this.transform.position = game2.transform.position;
        
    }
}
