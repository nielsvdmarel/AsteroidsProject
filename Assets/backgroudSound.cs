using UnityEngine;
using System.Collections;

public class backgroudSound : MonoBehaviour {

    public AudioClip[] bulletSounds;
    private AudioSource audioSourceComponent;
    public bool LastSound;

    // Use this for initialization
    void Start () {
        LastSound = false;
        audioSourceComponent = this.GetComponent<AudioSource>();
        audioSourceComponent.PlayOneShot(bulletSounds[0], 0.7F);
        InvokeRepeating("mid", bulletSounds[0].length-0.1f, bulletSounds[1].length-0.1f);
    }
	
	// Update is called once per frame
	void Update () {
        


	}

    private void mid()
    {
        audioSourceComponent.PlayOneShot(bulletSounds[1], 0.7F);
    }
}
