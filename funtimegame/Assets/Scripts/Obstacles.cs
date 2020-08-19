using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private float delay;
    public float repeat = 5.0f;
    public GameObject obstacles;

    // Start is called before the first frame update
    void Start()
    {
        delay = Random.Range(0.5f, 1.5f);
        InvokeRepeating("Spawn", delay, repeat);
    }

    void Spawn()
    {
        Vector2 position = new Vector2(Random.Range(-2.0f, 2.0f), 10);
        Instantiate(obstacles, position, Quaternion.identity);
        
    }

    void Update()
    {
        if (transform.position.y < -7)
        {
            Destroy(this.gameObject);
        }
    }
}
