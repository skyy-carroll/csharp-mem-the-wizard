using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController1 : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    public float horizontalInput;
    public float speed;
    public float jumpForce;

    public Rigidbody2D playerRb;

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public GameObject fireProjectilePrefab;
/*
    public Transform firePoint;
    public Vector2 lookDirection;
    public float lookAngle;
    public float fireSpeed;*/

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.RightArrow)) //arrow key movements
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
            ChangeSprite(0);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * horizontalInput * Time.deltaTime * speed);
            ChangeSprite(1);

        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(fireProjectilePrefab, transform.position + new Vector3(1, 0, 0), fireProjectilePrefab.transform.rotation);

        }

    }

    public void GameOver()
    {
        //GameOverScreen.Setup()
    }

    void ChangeSprite(int spriteArrayNum)
    {
        spriteRenderer.sprite = spriteArray[spriteArrayNum];
    }
}
