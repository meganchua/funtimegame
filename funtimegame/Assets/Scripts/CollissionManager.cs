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
        if(other.gameObject.tag == "Point")
        {
            Debug.Log("point");
            Destroy(other.gameObject);
        }
        */


        //if(other.gameObject.tag == "Obstacle")
        //{

            Destroy(other.gameObject);
            //this.gameObject.SetActive(false);
            //Application.LoadLevel(Application.loadedLevel);

        //}

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
