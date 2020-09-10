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


    public Color RedColor, OrangeColor, PurpleColor, PinkColor, TealColor, BlackColor;
    public GameObject healthBar;
    Renderer rend;

    public Canvas ColorCanvas;

    public float spawnRate = 5f;

    float nextSpawn = 0f;

    int whatToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        RedColor = new Color32(255, 46, 99, 255);
        OrangeColor = new Color32(251, 172, 145, 255);
        PurpleColor = new Color32(170, 150, 218, 255);
        PinkColor = new Color32(255, 187, 204, 255);
        TealColor = new Color32(48, 227, 202, 255);
        BlackColor = new Color32(48, 56, 65, 255);

        blue.tag = "Death Black";
        red.tag = "Death Red";
        yellow.tag = "Death Orange";
        green.tag = "Death Teal";
        pink.tag = "Death Pink";
        purple.tag = "Death Purple";

        rend = healthBar.GetComponent<SpriteRenderer>();
        rend.material.SetColor("_Color", Color.white);
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
                    rend.material.SetColor("_Color", BlackColor);

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
                    rend.material.SetColor("_Color", RedColor);

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
                    rend.material.SetColor("_Color", OrangeColor);

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
                    rend.material.SetColor("_Color", TealColor);

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
                    rend.material.SetColor("_Color", PinkColor);

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
                    rend.material.SetColor("_Color", PurpleColor);

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
