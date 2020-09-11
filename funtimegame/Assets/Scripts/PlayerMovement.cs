using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;

    public static int isGameOver;

    public GameOver gameOver;
    public Score score;
    public int finalScore;

    public static float health;
    public float decPerMin;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 3f;

        isGameOver = 0;

        health = .17f;
        decPerMin = 1f;
    }

    private void Update()
    {
        health -= Time.deltaTime * decPerMin / 60f;

        if(health <= 0)
        {
            isGameOver = 1;
            finalScore = Score.scoreAmount;
            gameOver.GameOverMenu(finalScore);
            Destroy(this.gameObject);          
        }

        // touch input
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

        // arrow keys (DOESNT WORK)
        /*
        Vector3 pos = transform.position;
        if(Input.GetKey("a"))
        {
            pos.x -= moveSpeed * Time.deltaTime;
            Debug.Log("A pressed");
        }
        if(Input.GetKey("d"))
        {
            pos.x += moveSpeed * Time.deltaTime;
            Debug.Log("D Pressed");
        }
        transform.position = pos;
        */
    }
}
