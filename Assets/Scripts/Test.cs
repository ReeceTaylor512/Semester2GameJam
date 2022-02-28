using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    public float jumpSpeed, speed = 5f;
    public Rigidbody2D rb;
    bool isGrounded;
    public static GameObject spawnPoint;
    public SpriteRenderer playerSprite, gunSprite;

    public Quaternion leftRotation = new Quaternion(0,180,0,0);
    public Quaternion rightRotation = new Quaternion(0, 0, 0, 0);

    public Vector3 leftSpawn;
    public Vector3 rightSpawn; 

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.Find("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(isGrounded);
        Vector2 move = rb.velocity;

        float hor = Input.GetAxis("Horizontal");
        move.x = hor * speed;

        if (move.x == 0)
        {
           
            Animation.playAnimation = false;
        }

        if(move.x > 0 || move.x < -0) 
        {
            
            Animation.playAnimation = true;
        }


        if (move.x < -0)
        {
            playerSprite.flipX = true;
            gunSprite.flipX = true;
            spawnPoint.transform.localPosition = leftSpawn;
            spawnPoint.transform.localRotation = leftRotation;
        }
        else if (move.x > 0)
        {

            playerSprite.flipX = false;
            gunSprite.flipX = false;
            spawnPoint.transform.localPosition = rightSpawn;
            spawnPoint.transform.localRotation = rightRotation;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            move.y = jumpSpeed;
        }
        rb.velocity = move;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Tilemap")
        {

            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        isGrounded = false;
    }

}

