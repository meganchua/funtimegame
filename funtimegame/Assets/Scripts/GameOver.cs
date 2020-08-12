using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public Text highScoreCongratsText;
    int highScore;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOverMenu(int score)
    {
        gameObject.SetActive(true);

        if(score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;
            highScoreCongratsText.gameObject.SetActive(true);
        }

        scoreText.text = "Score: " + score;
        highScoreText.text = "High Score: " + highScore;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Start");
    }
}
