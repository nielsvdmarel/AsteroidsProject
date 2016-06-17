using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    public string scene;

	
	void Start () {
	
	}
	
	
	void OnGUI () {
	    if (GUI.Button(new Rect(-100, 0, 0,0),""))
        {
            Initiate.Fade(scene, Color.black, 0.5f);
        }
	}
}
