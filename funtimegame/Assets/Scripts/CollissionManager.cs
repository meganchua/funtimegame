using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionManager : MonoBehaviour
{
    //public GameObject obstacle; //might need to add more depending on how many unique obstacles
    //public GameObject point;
    //public int pointCount++;

    //public GameOver gameOver;
    //public Score score;
    //public int finalScore;

    public Color bluecolor;
    public Color yellowcolor;


    private void OnTriggerEnter2D(Collider2D other)
    {
        //GameObject e = Instantiate(explosion) as GameObject;
        //e.transform.position = transform.position;

        /*
        if(other.gameObject.tag == "Score") -OR- if(other.gameObject.CompareTag("Point"))
        {
            Debug.Log("point");
            Destroy(other.gameObject);
        }
        */



        if(other.gameObject.CompareTag("Death"))
        {
            /*
            PlayerMovement.health = PlayerMovement.health - 10;
            Debug.Log(PlayerMovement.health);
            Destroy(other.gameObject);
            */
            PlayerMovement.health -= 1;
            Debug.Log(PlayerMovement.health);
            Destroy(other.gameObject);
            GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
            //transform.GetComponent<Renderer>().material.color = bluecolor;
            
            /*
            finalScore = Score.scoreAmount;
            gameOver.GameOverMenu(finalScore);
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            */

            //this.gameObject.SetActive(false);
            //Application.LoadLevel(Application.loadedLevel);

        }
        else if(other.gameObject.CompareTag("Score"))
        {
            Score.scoreAmount += 1;
            Destroy(other.gameObject);

            GetComponent<SpriteRenderer>().color = other.gameObject.GetComponent<SpriteRenderer>().color;
            //this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
            //this.gameObject.material.SetColor("_Color", Color.red);

            //transform.GetComponent<Renderer>().material.color = yellowcolor;
        }

        /*
        //point system
        else if(other.gameObject.tag == "Point")
        {
            pointCount++; 
            Destroy(other.GameObject);
        }
        */
    }
}
