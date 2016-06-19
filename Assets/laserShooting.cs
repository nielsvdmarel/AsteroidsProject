using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class laserShooting : MonoBehaviour {

    public GameObject headLaser;
    public int laserTime;
    public int laserTimeLeft;
    public bool lasersound;
    public AudioClip lasersoundClip;

    private Text lasertext;
    private GameObject[] lasers;
    private int laserCounter;
    private bool deleteLaser = false;
    private bool createLaser = false;
    private AudioSource audioSourceComponent;

    // Use this for initialization
    void Start() {
        audioSourceComponent = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

       /* if (Input.GetKeyDown(KeyCode.V))
        {
            if (createLaser){createLaser = false; }
            else{createLaser = true;}
        }*/
        /*if (Input.GetKeyDown(KeyCode.B))
        {
            deleteLaser = true;
        } */
        if (createLaser)
        {
            instantiateLaser();
        }
        else if(GameObject.FindGameObjectsWithTag("laser").Length > 0)
        {
            GameObject[] allLasers = GameObject.FindGameObjectsWithTag("laser");
            Destroy(allLasers[allLasers.Length-1]);
        }

        if(createLaser && laserTimeLeft > 0)
        {
            lasertext = GameObject.Find("laserTimer").GetComponent<Text>();
            lasertext.text = "" + laserTimeLeft;
        }
        else
        {
            lasertext.text = "";
        }


        if(GameObject.FindGameObjectsWithTag("laser").Length < 1)
        {
            laserCounter = 1;
            if (!lasersound)
            {
                audioSourceComponent.Stop();
                lasersound = true;
                CancelInvoke();
            }
        }

        if(GameObject.FindGameObjectsWithTag("laser").Length > 1 &&  lasersound)
        {
            
            InvokeRepeating("lasershounds", 0, lasersoundClip.length-1f);
            lasersound = false;

        }

    }

    public int laserlengtget()
    {
        return laserCounter;
    }
    public void instantiateLaser()
    {
        Instantiate(headLaser);
        laserCounter++;
    }
    public void MinLaserCounter(int minLaser)
    {
        laserCounter -= minLaser;
    }
    public void LaserCounterEq(int laser)
    {
        laserCounter = laser;
    }
    public void laserStart()
    {
        if (createLaser) { createLaser = false; }
        else { createLaser = true; }
        laserTimeLeft = laserTime;
        StartCoroutine(timerfunction());
    }
    IEnumerator timerfunction()
    {
        while (laserTimeLeft > 0)
        {
            yield return new WaitForSeconds(1);
            laserTimeLeft -= 1;
        }
        if (laserTimeLeft == 0)
        {
            //timertext.text = "";
            createLaser = false;

        }
    }

    private void lasershounds()
    {
        audioSourceComponent.PlayOneShot(lasersoundClip, 1F);
    }

}
