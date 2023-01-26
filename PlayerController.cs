using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private float xRange = 1;
    //private float yRange = 1;

    public float horizontalInput;
    public float speed;
    public float jumpForce;

    //private bool isOnGround = true;
    //public bool doubleJumpUsed = false;


    public Rigidbody2D playerRb;

    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    public GameObject fireProjectilePrefab;


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

/*        if (transform.position.x > xRange) //barriers
        {
            new Vector2(xRange, transform.position.y);
        }

        if (transform.position.x < -xRange)
        {
            new Vector2(-xRange, transform.position.y);
        }

        if (transform.position.y > yRange)
        {
            new Vector2(transform.position.x, yRange);
        }

        if (transform.position.y < -yRange)
        {
            new Vector2(transform.position.x, -yRange);
        }*/

        if (Input.GetKeyDown(KeyCode.RightArrow)) //arrow key movements
        {
            transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);
            ChangeSprite(2);
            
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * horizontalInput * Time.deltaTime * speed);
            ChangeSprite(3);
            
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(fireProjectilePrefab, transform.position + new Vector3(1,0,0), fireProjectilePrefab.transform.rotation);
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void ChangeSprite(int spriteArrayNum)
    {
        spriteRenderer.sprite = spriteArray[spriteArrayNum];
    }

}
