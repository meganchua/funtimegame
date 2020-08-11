using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float delay = 0.7f;
    public float repeat = 5.0f;
    public GameObject obstacles;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, repeat);
    }

    // Update is called once per frame
    void Spawn()
    {
        Vector2 position = new Vector2(Random.Range(-2, 2), 10);
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
