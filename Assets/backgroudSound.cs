using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class backgroudSound : MonoBehaviour {

    public AudioClip[] bulletSounds;
    public AudioClip bossSound;
    private AudioSource audioSourceComponent;
    private bool setinvoke;
    public bool boss;
    public bool LastSound;
    public int clip;
    private int oldClip;
    public bool win;
    public string scene;
    public string scene2;

    // Use this for initialization
    void Start () {

        setinvoke = false;
        clip = 0;
        LastSound = false;
        audioSourceComponent = this.GetComponent<AudioSource>();
        //audioSourceComponent.PlayOneShot(bulletSounds[0], 0.7F);
        //InvokeRepeating("mid", bulletSounds[0].length-0.3f, bulletSounds[1].length-0.3f);
        StartCoroutine(timerfunction());
    }
	
	// Update is called once per frame
	void Update () {
        if(clip == 3 && oldClip != 3)
        {
            audioSourceComponent.Stop();
            audioSourceComponent.PlayOneShot(bulletSounds[clip], 0.7F);
            //StartCoroutine(timerfunction());
        }
        oldClip = clip;

	}

    


    IEnumerator timerfunction()
    {

        if(clip == 3)
        { 
            yield return new WaitForSeconds(bulletSounds[clip].length);
            clip = 0;
        }
        int startClip = clip;
        if(clip == 0)
        {
            clip = 1;
        }
        audioSourceComponent.PlayOneShot(bulletSounds[startClip], 0.7F);
        yield return new WaitForSeconds(bulletSounds[startClip].length);
        if(clip == 2)
        {
            if (win)
            {
                Initiate.Fade(scene, Color.black, 0.5f);
                //SceneManager.LoadScene("Lose");
                Debug.Log("win");
                
            }
            else
            {
                Initiate.Fade(scene2, Color.black, 0.5f);
                //SceneManager.LoadScene("Lose");
                Debug.Log("Lose");
            }
        }
            StartCoroutine(timerfunction());
        
        
    }
}
