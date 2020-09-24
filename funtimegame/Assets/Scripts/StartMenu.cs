using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        StartCoroutine(WaitForSceneLoad());
    }

    private IEnumerator WaitForSceneLoad()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Game");

    public void PlayGame() 
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
} // class
