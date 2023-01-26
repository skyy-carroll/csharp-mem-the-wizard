using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameeManager : MonoBehaviour
{

    public GameObject endGameScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if (enemies == 0)
        {
            endGameScreen.SetActive(true);
        }

    }

    void GameOver()
    {

    }

}
