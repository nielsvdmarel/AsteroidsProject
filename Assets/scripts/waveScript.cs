using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class waveScript : MonoBehaviour
{

    public int enemiesDied;
    public int wave;
    public int total;

    public int maxEnemies;
    public float spawndistance;
    public float waveStartDelay;
    public float[] enemySpawnDelay;

    public int waves;

    public GameObject[] pickups;

    public float[] speed;
    public float[] shield;
    public float[] health;
    public float[] laser;

    public GameObject[] Enemies;
    public GameObject hunterObject;
    public GameObject boss;
    

    
    public int[] enemy1;
    public int[] enemy2;
    public int[] enemy3;
    public int[] hunter;

    public bool playercanmove = false;

    
    
    private SpriteRenderer backColorRenderer;
    private float enemyCounter;
    private float timeBeforeWave;
    private Text wavetimer;



    void Start()
    {
        total = enemy1[wave] + enemy2[wave] + enemy3[wave] + hunter[wave];
        wavetimer = GameObject.Find("waveTimer").GetComponent<Text>();
        timeBeforeWave = waveStartDelay;

        InvokeRepeating("spawn", waveStartDelay, Random.Range(enemySpawnDelay[0], enemySpawnDelay[1]));
        //total = enemy1[wave] + enemy2[wave] + enemy3[wave] + hunter[wave];
        enemyCounter = 0;
        wave = 0;
        StartCoroutine(timerfunction());

    }


    void Update()
    {
        

        pickUps();
        if (enemyCounter == total)
        {
            CancelInvoke();
            if (enemiesDied == total)
            {
            wave++;
                if (wave == waves)
                {
                    enemyCounter = -1;
                    Instantiate(boss);
                    GameObject.Find("Audio Source").GetComponent<backgroudSound>().clip = 3;
                    //GameObject.Find("Audio Source").GetComponent<backgroudSound>().mid();

                } else {
                    GameObject[] allPickUps = GameObject.FindGameObjectsWithTag("pickup laserbeam");
                    for(int i = 0; i < allPickUps.Length; i++)
                    {
                        Destroy(allPickUps[i]);
                    }
                    timeBeforeWave = waveStartDelay;
                    StartCoroutine(timerfunction());
                    total = enemy1[wave] + enemy2[wave] + enemy3[wave] + hunter[wave];
                    InvokeRepeating("spawn", waveStartDelay, Random.Range(enemySpawnDelay[0], enemySpawnDelay[1]));
                    pickUps();
                    print("test");
                    enemyCounter = 0;
                    enemiesDied = 0;
                }

            }
        }
        }
    private void spawn()
    {
        if (GameObject.FindGameObjectsWithTag("enemy").Length < maxEnemies+1)
        {
            int totalSpawn = enemy1[wave] + enemy2[wave] + enemy3[wave] + hunter[wave];
            float random = Random.Range(1, totalSpawn);


            float enemy1c = enemy1[wave];
            float enemy2c = enemy2[wave] + enemy1c;
            float enemy3c = enemy3[wave] + enemy2c;
            float hunterc = hunter[wave] + enemy2c;

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
            if (random < hunterc + 1 && random > enemy3c)
            {
                enemyCounter++;
                Instantiate(hunterObject);
                hunter[wave] -= 1;
            }
        }
    }
    private void pickUps()
    {
        int total = speed.Length + health.Length + laser.Length + shield.Length;
        
            if(speed[wave] > 0) { speed[wave] -= 1; Instantiate(pickups[3]); }
            if (health[wave] > 0) { health[wave] -= 1; Instantiate(pickups[0]); }
            if (laser[wave] > 0) { laser[wave] -= 1; Instantiate(pickups[1]); }
            if (shield[wave] > 0) { shield[wave] -= 1; Instantiate(pickups[2]); }
        
    }
    public void enemmiesDiedPlus()
    {
        enemiesDied++;
    }

    IEnumerator timerfunction()
    {
        while (timeBeforeWave > 0)
        {
            yield return new WaitForSeconds(1);
            timeBeforeWave -= 1;
            wavetimer.text = "" + timeBeforeWave;
        }

        if (timeBeforeWave == 0)
        {
            playercanmove = true;
            wavetimer.text = "";
            
        }
    }


}
