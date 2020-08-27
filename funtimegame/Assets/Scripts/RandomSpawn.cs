
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{   
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6;

    private float spawnRate;
    public float repeat = 10.0f;

    float nextSpawn = 0f;

    int whatToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(0.5f, 1.5f);
        InvokeRepeating("Update", spawnRate, repeat);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = new Vector2(Random.Range(-2.0f, 2.0f), 10);

        if(PlayerMovement.isGameOver == 0)
        {

            if (Time.time > nextSpawn)
            {
                whatToSpawn = Random.Range(1, 7); //7 is exclusive
  
                switch (whatToSpawn)
                {
                    case 1:
                        Instantiate(prefab1, position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(prefab2, position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(prefab3, position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(prefab4, position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(prefab5, position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(prefab6, position, Quaternion.identity);
                        break;
            }
            
            nextSpawn = Time.time + spawnRate;
        }

        } //playermovement

    }

 
}
