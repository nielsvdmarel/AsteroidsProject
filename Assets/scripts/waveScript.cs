using UnityEngine;
using System.Collections;

public class waveScript : MonoBehaviour {

    public GameObject[] Enemies;
    public int[] waves;
    public int[] enemy1;
    public int[] enemy2;
    public int[] enemy3;
    

    //public Color[] color;
    //public GameObject backColor;

    public int enemiesDied;
    private int wave;
    private SpriteRenderer backColorRenderer;
    private float enemyCounter;
    private bool started;
    

	
	void Start () {
        
        enemyCounter = 0;
        wave = 0;
        
    }
	
	
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
        int total = enemy1[wave] + enemy2[wave] + enemy3[wave];
        float random = Random.Range(1, total);
        

        float enemy1c = enemy1[wave];
        float enemy2c = enemy2[wave] + enemy1c;
        float enemy3c = enemy3[wave] + enemy2c;

        if (random < enemy1c + 1)
        {
            enemyCounter++;
            Instantiate(Enemies[0]);
            enemy1[wave] -= 1;
        }
        if (random < enemy2c + 1 && random > enemy1c)
        {
            enemyCounter++;
            Instantiate(Enemies[1]);
            enemy2[wave] -= 1;
        }
        if (random < enemy3c + 1 && random > enemy2c)
        {
            enemyCounter++;
            Instantiate(Enemies[2]);
            enemy3[wave] -= 1;
        }
        if(total == 0 && waves[wave] > 0)
        {
            print("aangegeven enemies op");
            int randomenemy = Random.Range(1, 4);
            if(randomenemy == 1) { Instantiate(Enemies[0]); }
            if (randomenemy == 2) { Instantiate(Enemies[1]); }
            if (randomenemy == 3) { Instantiate(Enemies[2]); }
        }

    }

}
