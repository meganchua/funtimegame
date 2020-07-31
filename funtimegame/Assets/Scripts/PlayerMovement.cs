using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 300;
    public GameObject player;

    private Rigidbody2D playerBody;
    private float ScreenWidth;

    void Start()
    {
        ScreenWidth = Screen.width;
        playerBody = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        int i = 0;
        while(i < Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > ScreenWidth/2)
            {
                MovePlayer(10.0f);
            }
            if(Input.GetTouch(i).position.x < ScreenWidth/2)
            {
                MovePlayer(-10.0f);
            }
            ++i;
        }
    }

    void FixedUpdate()
    {
        #if UNITY_EDITOR
        MovePlayer(Input.GetAxis("Horizontal"));
        #endif
    }

    private void MovePlayer(float horizontalInput)
    {
        playerBody.AddForce(new Vector2(horizontalInput = moveSpeed = Time.deltaTime, 0));
    }
}
