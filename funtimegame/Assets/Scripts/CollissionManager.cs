using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionManager : MonoBehaviour
{
    // changing bucket color
    public GameObject white, black, red, orange, teal, pink, purple;

    void Start()
    {
        white.SetActive(true);
        black.SetActive(false);
        red.SetActive(false);
        orange.SetActive(false);
        teal.SetActive(false);
        pink.SetActive(false);
        purple.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // changing bucket color
        if(other.gameObject.tag.Contains("Black"))
        {
            white.SetActive(false);
            black.SetActive(true);
            red.SetActive(false);
            orange.SetActive(false);
            teal.SetActive(false);
            pink.SetActive(false);
            purple.SetActive(false);            
        }
        else if(other.gameObject.tag.Contains("Red"))
        {
            white.SetActive(false);
            black.SetActive(false);
            red.SetActive(true);
            orange.SetActive(false);
            teal.SetActive(false);
            pink.SetActive(false);
            purple.SetActive(false);            
        }  
        else if(other.gameObject.tag.Contains("Orange"))
        {
            white.SetActive(false);
            black.SetActive(false);
            red.SetActive(false);
            orange.SetActive(true);
            teal.SetActive(false);
            pink.SetActive(false);
            purple.SetActive(false);            
        } 
        else if(other.gameObject.tag.Contains("Teal"))
        {
            white.SetActive(false);
            black.SetActive(false);
            red.SetActive(false);
            orange.SetActive(false);
            teal.SetActive(true);
            pink.SetActive(false);
            purple.SetActive(false);            
        } 
        else if(other.gameObject.tag.Contains("Pink"))
        {
            white.SetActive(false);
            black.SetActive(false);
            red.SetActive(false);
            orange.SetActive(false);
            teal.SetActive(false);
            pink.SetActive(true);
            purple.SetActive(false);            
        } 
        else if(other.gameObject.tag.Contains("Purple"))
        {
            white.SetActive(false);
            black.SetActive(false);
            red.SetActive(false);
            orange.SetActive(false);
            teal.SetActive(false);
            pink.SetActive(false);
            purple.SetActive(true);            
        }  
        else
        {
            white.SetActive(true);
            black.SetActive(false);
            red.SetActive(false);
            orange.SetActive(false);
            teal.SetActive(false);
            pink.SetActive(false);
            purple.SetActive(false);             
        }    

        //healthBar.GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
        Destroy(other.gameObject);

        //if(other.gameObject.CompareTag("Death"))
        if(other.gameObject.tag.Contains("Death"))
        {
            // Health goes down
            PlayerMovement.health -= 0.05f;

            // Changes the color of player to color of what it ran into
            GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;

            Destroy(other.gameObject);
        }
        //else if(other.gameObject.CompareTag("Score"))
        else if(other.gameObject.tag.Contains("Score"))
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
