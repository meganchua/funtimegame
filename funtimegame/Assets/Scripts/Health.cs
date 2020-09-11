using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    Vector3 localScale;

    public GameObject front;

    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = PlayerMovement.health;
        transform.localScale = localScale;

        if(PlayerMovement.health < 0)
        {
            front.GetComponent<Renderer>().enabled = false;
        }
    }
}
