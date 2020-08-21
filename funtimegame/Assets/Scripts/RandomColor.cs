using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomColor : MonoBehaviour
{
    public TMP_Text color1, color2, color3, color4, color5, color6;

    public float spawnRate = 1f;

    float nextSpawn = 0f;

    int whatToSpawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 7); //7 is exclusive

            switch (whatToSpawn)
            {
                case 1:
                    color1.enabled = true;
                    color2.enabled = false;
                    color3.enabled = false;
                    color4.enabled = false;
                    color5.enabled = false;
                    color6.enabled = false;
                    break;
                case 2:
                    color1.enabled = false; ;
                    color2.enabled = true;
                    color3.enabled = false;
                    color4.enabled = false;
                    color5.enabled = false;
                    color6.enabled = false;
                    break;
                case 3:
                    color1.enabled = false;
                    color2.enabled = false;
                    color3.enabled = true;
                    color4.enabled = false;
                    color5.enabled = false;
                    color6.enabled = false;
                    break;
                case 4:
                    color1.enabled = false;
                    color2.enabled = false;
                    color3.enabled = false;
                    color4.enabled = true;
                    color5.enabled = false;
                    color6.enabled = false;
                    break;
                case 5:
                    color1.enabled = false;
                    color2.enabled = false;
                    color3.enabled = false;
                    color4.enabled = false;
                    color5.enabled = true;
                    color6.enabled = false;
                    break;
                case 6:
                    color1.enabled = false;
                    color2.enabled = false;
                    color3.enabled = false;
                    color4.enabled = false;
                    color5.enabled = false;
                    color6.enabled = true;
                    break;
            }

            nextSpawn = Time.time + spawnRate;

        }
    }
}
