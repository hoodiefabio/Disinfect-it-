using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject myEnemy;
    public GameObject secondEnemy;
    public GameOver gameOver;
    public GameObject pauseMenu;
    public float startAmount = 4f;
    public float spawnTime = 2f;
    public float secondSpawnTime = 5f;
    private float spawnTimer;
    private float timer2;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies(startAmount);
        spawnTimer = spawnTime;
        timer2 = secondSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver._gameOver == false && pauseMenu.activeInHierarchy == false)
        {
            spawnTimer = spawnTimer - Time.deltaTime;
            timer2 = timer2 - Time.deltaTime;

            if (spawnTimer < 0)
            {
                SpawnEnemies(Random.Range(1, 3));
                spawnTimer = spawnTime;
            }
            if (timer2 < 0)
            {
                SpawnToughEnemy();
                timer2 = secondSpawnTime;
            }
        }
    }

    void SpawnEnemies(float amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(myEnemy, new Vector3(Random.Range(-20,20), Random.Range(-10,10), 0), Quaternion.identity);
        }
    }

    void SpawnToughEnemy()
    {
        Instantiate(secondEnemy, new Vector3(Random.Range(-20, 20), Random.Range(-10, 10), 0), Quaternion.identity);
    }
}
