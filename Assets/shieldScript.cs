using UnityEngine;
using System.Collections;

public class shieldScript : MonoBehaviour {

    public Color shieldOff;
    public Color shieldOn;

    public bool shield;

    void Update () {
        if (shield)
        {
            this.GetComponent<SpriteRenderer>().color = shieldOn;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color = shieldOff;
        }
	}
}
