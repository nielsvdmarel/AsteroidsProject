using UnityEngine;
using System.Collections;

public class waveScript : MonoBehaviour {

    public GameObject Enemy;
    public GameObject backColor;
    public int enemiesDied;
    public float[] waves;
    //public Color[] color;
   

    private int wave;
    private SpriteRenderer backColorRenderer;
    private float enemyCounter;
    private bool started;
    

	// Use this for initialization
	void Start () {
        //backColorRenderer = backColor.GetComponent<SpriteRenderer>();
        //backColorRenderer.color = new Color(255F, 40F, 40F, 255F);
        //Debug.Log(waves[2]);
        enemyCounter = 0;
        wave = 0;
    }
	
	// Update is called once per frame
	void Update () {
	if (enemiesDied == waves[wave])
        {
            //Debug.Log("wave ends");
            enemyCounter = 0;
            enemiesDied = 0;
            wave++;
            started = false;
        }

    if (enemyCounter == waves[wave])
        {
            //Debug.Log("spawning ends");
            CancelInvoke();             
        }

        if (wave > waves.Length)
        {
            //
        }
   
        if (started == false)
        {         
            InvokeRepeating("spawn", 0.0f, 5.0f);
            started = true;
        }
	}
    private void spawn()
    {
        enemyCounter++;
        Instantiate(Enemy);
        
    }

}
