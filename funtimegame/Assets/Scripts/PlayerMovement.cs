using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;


    public GameOver gameOver;
    public Score score;
    public int finalScore;

    public static float health;
    public float decPerMin;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 3f;

        health = 4f;
        decPerMin = 25f;
    }

    private void Update()
    {
        health -= Time.deltaTime * decPerMin / 60f;

        //Debug.Log(health);
        if(health <= 0)
        {
            finalScore = Score.scoreAmount;
            gameOver.GameOverMenu(finalScore);
            Destroy(this.gameObject);          
        }
        
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch(touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                        rb.velocity = new Vector2(-moveSpeed, 0f);

                    if(touch.position.x > Screen.width / 2)
                        rb.velocity = new Vector2(moveSpeed, 0f);
                    break;

                case TouchPhase.Ended:
                    rb.velocity = new Vector2(0f, 0f);
                    break;
            }
        }

    }

    /*
    public float moveSpeed = 300;
    public GameObject character;

    private Rigidbody2D characterBody;
    private float ScreenWidth;

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;

        while(i < Input.touchCount)
        {
            if(Input.GetTouch (i).position.x > ScreenWidth / 2)
            {
                //RunCharacter(1.0f);
                RunCharacter(0.25f);
            }
            if(Input.GetTouch (i).position.x < ScreenWidth / 2)
            {
                //RunCharacter(-1.0f);
                RunCharacter(-0.25f);
            }
            ++i;
        }
    }

    void FixedUpdate()
    {
        #if UNITY_EDITOR
        RunCharacter(Input.GetAxis("Horizontal"));
        #endif
    }

    private void RunCharacter(float horizontalInput)
    {
        characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }
    */
}
