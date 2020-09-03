using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
        Destroy(other.gameObject);

        if(other.gameObject.CompareTag("Death"))
        {
            // Health goes down
            PlayerMovement.health -= 0.05f;

            // Changes the color of player to color of what it ran into
            GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;

            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Score"))
        {
            // Score goes up
            Score.scoreAmount += 1;

            // Health goes up
            if(PlayerMovement.health > .35f)
                PlayerMovement.health = .45f;
            else                
                PlayerMovement.health += 0.1f; 

            // Changes the color of player to color of what it ran into
            GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;

            Destroy(other.gameObject);
        }
    }
}
