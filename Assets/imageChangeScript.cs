using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class imageChangeScript : MonoBehaviour {

    public Sprite speed;
    public Sprite laser;
    public Color[] trans;

    private bool selected;
    private bool haveApick;

	// Use this for initialization
	void Start () {
        //this.GetComponent<Image>().sprite = images;
	}
	
	// Update is called once per frame
	void Update () {
        setBools();
        if (selected)
        {
            this.GetComponent<Image>().sprite = laser;
        }
        if (!selected)
        {
            this.GetComponent<Image>().sprite = speed;
        }
        if (!haveApick)
        {
            this.GetComponent<Image>().color = trans[1];
        }
        else
        {
            this.GetComponent<Image>().color = trans[0];
        }
    }
    void setBools()
    {
        haveApick = GameObject.Find("Player").GetComponent<pickupUseScript>().gethave();
        selected = GameObject.Find("Player").GetComponent<pickupUseScript>().getSelected();


    }
}
