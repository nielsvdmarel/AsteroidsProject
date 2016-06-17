using UnityEngine;
using System.Collections;

public class bulletsShooting : MonoBehaviour {

    public GameObject BulletPrefab;
    public AudioClip[] bulletSounds;
    private AudioSource audioSourceComponent;
    //private Vector3 pos;
    //private Quaternion rot;

    void Start()
    {
        audioSourceComponent = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0))
        {
            if (GameObject.FindGameObjectsWithTag("laser").Length < 1)
            {
                Instantiate(BulletPrefab, transform.position, transform.rotation);
                audioSourceComponent.PlayOneShot(bulletSounds[Random.Range(0,3)], 0.7F);
            }
        }
    }
}
