using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Rigidbody2D enemyRb;
    public float speed;

    private float yRange = 3;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Wizard");

    }

    // Update is called once per frame
    void Update()
    {       //refer back to g
        if (transform.position.y > yRange || transform.position.y < -yRange) //y barriers
        {
            new Vector2(transform.position.x, yRange);
        }

        Vector2 playerToEnemyPos = player.transform.position - transform.position;
        //enemyRb.AddForce((playerToEnemyPos).normalized * speed * new Vector2(0,5));
        enemyRb.AddForce((playerToEnemyPos).normalized * speed + new Vector2(0, 5));


    }

    private void OnCollisionEnter2D(Collision2D collision) //if enemy hits player, it knocks the player back. may does damage? (implement health, or times knocked for a game over)
    {
        
    }
}
