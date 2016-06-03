using UnityEngine;
using System.Collections;

public class CamerFollow : MonoBehaviour {

    public Transform target;
    Camera mycam;
    public float Camera_follow_speed = 1.0f;
    public float zoomSize = 5;
	
	void Start ()
    {
        mycam = GetComponent<Camera>();
	}


    void Update()
    {

        //mycam.orthographicSize = (Screen.height / 100f / .5f); // dit bepaalt camera grote

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Camera_follow_speed) + new Vector3(0, 0, -10);
        }


        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            if (zoomSize > 2)
                zoomSize -=1;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (zoomSize < 20)
                zoomSize += 1;

        }

        GetComponent<Camera>().orthographicSize = zoomSize;


	}
}
