using UnityEngine;
using System.Collections;

public class bulletsShooting : MonoBehaviour {

    public GameObject BulletPrefab;
    //private Vector3 pos;
    //private Quaternion rot;

    void Start()
    {
        //rot = transform.rotation;
    }

    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0))
        {
            if (GameObject.FindGameObjectsWithTag("laser").Length < 1)
            {
                Instantiate(BulletPrefab, transform.position, transform.rotation);
            }
        }
    }
}
