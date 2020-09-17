using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionManager : MonoBehaviour
{
    // changing bucket color
    public GameObject white, black, red, orange, teal, pink, purple;
    public AudioSource good, bad;

    void Start()
    {
        white.SetActive(true);
        black.SetActive(false);
        red.SetActive(false);
        orange.SetActive(false);
        teal.SetActive(false);
        pink.SetActive(false);
        purple.SetActive(false);

        //GetComponent<AudioSource>().playOnAwake = false;
        /*good = GetComponent<AudioSource>();
        bad = GetComponent<AudioSource>();*/
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        /*bad.Play();*/

        // changing bucket color
        if (other.gameObject.tag.Contains("Black"))
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

        if(other.gameObject.tag.Contains("Death"))
        {
            // Health goes down
            PlayerMovement.health -= 0.01f;
            bad.Play();
        }
        else if(other.gameObject.tag.Contains("Score"))
        {
            // Score goes up
            Score.scoreAmount += 1;
            good.Play();

            // Health goes up
            if(PlayerMovement.health > .155f)
                PlayerMovement.health = .17f;
            else                
                PlayerMovement.health += 0.025f; 
        }

        Destroy(other.gameObject);
    }
}
