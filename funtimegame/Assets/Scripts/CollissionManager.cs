using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionManager : MonoBehaviour
{
    //public GameObject obstacle; //might need to add more depending on how many unique obstacles
    //public GameObject point;
    //public int pointCount++;

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
            //Destroy(this.gameObject);
            Destroy(other.gameObject);
            //this.gameObject.SetActive(false);
            //Application.LoadLevel(Application.loadedLevel);

        }
        else if(other.gameObject.CompareTag("Score"))
        {
            Score.scoreAmount += 1;
            Destroy(other.gameObject);
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
