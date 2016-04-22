using UnityEngine;
using System.Collections;

public class bulletsShooting : MonoBehaviour {

    public GameObject BulletPrefab;

    // Use this for initialization
    void Start()
    {
        Debug.Log("hi");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(BulletPrefab, transform.position, transform.rotation);
        }
    }
}
