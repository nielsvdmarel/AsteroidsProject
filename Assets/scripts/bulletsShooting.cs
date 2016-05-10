using UnityEngine;
using System.Collections;

public class bulletsShooting : MonoBehaviour {

    public GameObject BulletPrefab;
    private Vector3 pos;
    private Quaternion rot;

    void Start()
    {
        rot = transform.rotation;
    }

    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
    }
}
