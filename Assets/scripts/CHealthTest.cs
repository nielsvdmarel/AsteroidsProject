using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CHealthTest : MonoBehaviour {

    public Scrollbar HealthBar;
    public float Health = 5000;

    public void Damage(float value)
    {

        Health -= value;
        HealthBar.size = Health / 5000f;
    }

    void Update()
    {
       Health = GameObject.Find("MoederBoord").GetComponent<motherHealthScript>().currentHealth;
        HealthBar.size = Health / GameObject.Find("MoederBoord").GetComponent<motherHealthScript>().maxHealth;
    }


	



}
