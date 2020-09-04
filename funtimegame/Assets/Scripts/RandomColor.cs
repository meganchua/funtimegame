using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomColor : MonoBehaviour
{
    //edge case: at the start of the game, some of the tags are wrong
    public TMP_Text BlueText, RedText, YellowText, GreenText, PinkText, PurpleText;
    public GameObject blue, green, pink, purple, red, yellow;

    public Canvas ColorCanvas;

    public float spawnRate = 5f;

    float nextSpawn = 0f;

    int whatToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        blue.tag = "Death Black";
        red.tag = "Death Red";
        yellow.tag = "Death Orange";
        green.tag = "Death Teal";
        pink.tag = "Death Pink";
        purple.tag = "Death Purple";
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.health < 0)
        {
            ColorCanvas.sortingLayerName = "Default";
        }

        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 7); //7 is exclusive

            switch (whatToSpawn)
            {
                case 1: //blue
                    BlueText.enabled = true;
                    RedText.enabled = false;
                    YellowText.enabled = false;
                    GreenText.enabled = false;
                    PinkText.enabled = false;
                    PurpleText.enabled = false;
                    blue.tag = "Score Black";
                    red.tag = "Death Red";
                    yellow.tag = "Death Orange";
                    green.tag = "Death Teal";
                    pink.tag = "Death Pink";
                    purple.tag = "Death Purple";
                    break;
                case 2: //red
                    BlueText.enabled = false;
                    RedText.enabled = true;
                    YellowText.enabled = false;
                    GreenText.enabled = false;
                    PinkText.enabled = false;
                    PurpleText.enabled = false;
                    blue.tag = "Death Black";
                    red.tag = "Score Red";
                    yellow.tag = "Death Orange";
                    green.tag = "Death Teal";
                    pink.tag = "Death Pink";
                    purple.tag = "Death Purple";
                    break;
                case 3: //yellow
                    BlueText.enabled = false;
                    RedText.enabled = false;
                    YellowText.enabled = true;
                    GreenText.enabled = false;
                    PinkText.enabled = false;
                    PurpleText.enabled = false;
                    blue.tag = "Death Black";
                    red.tag = "Death Red";
                    yellow.tag = "Score Orange";
                    green.tag = "Death Teal";
                    pink.tag = "Death Pink";
                    purple.tag = "Death Purple";
                    break;
                case 4: //green
                    BlueText.enabled = false;
                    RedText.enabled = false;
                    YellowText.enabled = false;
                    GreenText.enabled = true;
                    PinkText.enabled = false;
                    PurpleText.enabled = false;
                    blue.tag = "Death Black";
                    red.tag = "Death Red";
                    yellow.tag = "Death Orange";
                    green.tag = "Score Teal";
                    pink.tag = "Death Pink";
                    purple.tag = "Death Purple";
                    break;
                case 5: //pink
                    BlueText.enabled = false;
                    RedText.enabled = false;
                    YellowText.enabled = false;
                    GreenText.enabled = false;
                    PinkText.enabled = true;
                    PurpleText.enabled = false;
                    blue.tag = "Death Black";
                    red.tag = "Death Red";
                    yellow.tag = "Death Orange";
                    green.tag = "Death Teal";
                    pink.tag = "Score Pink";
                    purple.tag = "Death Purple";
                    break;
                case 6: //purple
                    BlueText.enabled = false;
                    RedText.enabled = false;
                    YellowText.enabled = false;
                    GreenText.enabled = false;
                    PinkText.enabled = false;
                    PurpleText.enabled = true;
                    blue.tag = "Death Black";
                    red.tag = "Death Red";
                    yellow.tag = "Death Orange";
                    green.tag = "Death Teal";
                    pink.tag = "Death Pink";
                    purple.tag = "Score Purple";
                    break;
            }

            nextSpawn = Time.time + spawnRate;

        }
    }
}
