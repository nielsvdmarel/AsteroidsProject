using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class waveScript : MonoBehaviour
{

    
    public float spawndistance;
    public float waveStartDelay;
    public float[] enemySpawnDelay;
    public GameObject[] Enemies;
    public GameObject hunterObject;
    public GameObject boss;

    public int waves;
    public int[] enemy1;
    public int[] enemy2;
    public int[] enemy3;
    public int[] hunter;

    private int enemiesDied;
    private int wave;
    private SpriteRenderer backColorRenderer;
    private float enemyCounter;
    private int total;



    void Start()
    {
        InvokeRepeating("spawn", waveStartDelay, Random.Range(enemySpawnDelay[0], enemySpawnDelay[1]));
        total = enemy1[wave] + enemy2[wave] + enemy3[wave];
        enemyCounter = 0;
        wave = 0;
    }


    void Update()
    {
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
                    
                } else {
                    total = enemy1[wave] + enemy2[wave] + enemy3[wave];
                    InvokeRepeating("spawn", waveStartDelay, Random.Range(enemySpawnDelay[0], enemySpawnDelay[1]));
                    enemyCounter = 0;
                    enemiesDied = 0;
                }
            }
        }
    }
    private void spawn()
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
    public void enemmiesDiedPlus()
    {
        enemiesDied++;
    }

}
