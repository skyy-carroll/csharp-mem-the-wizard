using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D enemyRb;
    public float speed;
    //public GameObject player;
    private GameObject player;
    //public Scene gameOverScene;


    //public AudioClip bumpClip; //public sound bites
   // private AudioSource enemyAudio; //private enemy variable thats emitting the sound


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        //enemyAudio = GetComponent<AudioSource>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerToEnemyPos = (player.transform.position - transform.position).normalized;
        //enemyRb.AddForce((playerToEnemyPos).normalized * speed + new Vector3(transform.position.x, 5, transform.position.z));

        //enemyRb.AddForce((playerToEnemyPos).normalized * speed * new Vector2(0,5));
        //enemyRb.AddForce((playerToEnemyPos).normalized * speed, ForceMode2D.Impulse);
        enemyRb.AddForce(playerToEnemyPos * speed);

        //enemyRb.AddForce((playerToEnemyPos).normalized * speed);

/*        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies = 0)
        {
            SceneManager.SetActiveScene(gameOverScene);
        }*/

    }

/*    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            enemyAudio.PlayOneShot(bumpClip, 1.0f);
        }
    }*/
}
