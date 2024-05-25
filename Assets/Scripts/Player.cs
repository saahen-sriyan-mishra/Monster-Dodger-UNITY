using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Action
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    //Movement
    private float movementX;

    //Render
    private SpriteRenderer sr;

    //component Type
    private Rigidbody2D MyBody;

    //Animation 
    private Animator anim;
    private string WALK_ANIMATION = "Walk 0";


    //ON Ground
    private bool BodyOnGround = true;
    private string GROUND_TAG = "OnGround";

    //Touching monsters
    private bool TouchingMonsters = true;
    private string TOUCH_TAG = "Monsters";



    //show score
    private ScoreManager scoreManager;

    //Show Game Over
    private GameOverManager gameOverManager;


    //To Have Befor Start
    //got the component assigned
    private void Awake()
    {
        MyBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();


        scoreManager = FindObjectOfType<ScoreManager>(); // Find the ScoreManager in the scene
        gameOverManager = FindObjectOfType<GameOverManager>(); //Find score manager in scene
    }


    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        
    }

    private void FixedUpdate()
    {
        Jump();
    }


    void PlayerMoveKeyboard ()
    {
        movementX = Input.GetAxisRaw("Horizontal");


        //Debug.Log("" + movementX);

        transform.position = transform.position + new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;

        // Debug.Log("" + transform.position + "" + movementX);
        // x changes
    }


    void AnimatePlayer ()
    {

        //Right
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }

        //Left
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }

        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
    }

    void Jump ()
    {
        if (Input.GetButtonDown ("Jump") && BodyOnGround == true ) 
        {
           // transform.position = transform.position + new Vector3(0f, 10f, 0f) * jumpForce * Time.deltaTime;
           //jump within air not possible (Physics)

           //Physics jum to add instant force on impulse tthat is not continous, jump force added to 0
           MyBody.AddForce(new Vector2 (0f, jumpForce), ForceMode2D.Impulse);
           BodyOnGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if contact/collision is there, the whichever object hold OnGround tag is is true: here ground
        if (collision.gameObject.CompareTag(GROUND_TAG))
        {
            BodyOnGround = true;
        }

        //Destroy the player if touch
        if(collision.gameObject.CompareTag(TOUCH_TAG))
        {
            HandlePlayerDeathAndScore();
            
        }

    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(TOUCH_TAG))
        {
            HandlePlayerDeathAndScore();
        }
    }

    private void HandlePlayerDeathAndScore ()
    {
        scoreManager.StopCounting(); // Stop counting the score
        gameOverManager.ShowText(); //Show game over text
        Destroy(gameObject);
        
    }

}























