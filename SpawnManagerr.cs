using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManagerr : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnInterval = 1.5f;

    private Vector3 spawnPos = new Vector3(27, 14, 0);

    private float startDelay = 3;
    private float repeatRate = 5;

    private int randomObstacle;
    private PlayerController1 player;

    public int enemyCount;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
       /*  int enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies = 0)
        {
            //SceneManager.SetActiveScene(gameOverScene);
            gameObject.SetActive(true);
        }*/
    }

    void SpawnEnemies()
    {
        randomObstacle = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[randomObstacle], spawnPos, enemyPrefabs[randomObstacle].transform.rotation);

    }
}
