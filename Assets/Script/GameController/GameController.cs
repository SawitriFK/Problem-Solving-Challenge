using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public float time = 100;
    public bool gameHasEnded = false;
    float s;
    public GameObject UIGameover;

    void Update()
    {
        s += Time.deltaTime;
        if (s >= 1)
        {
            time--;
            s = 0;
        }

        if (time <= 0)
        {
            gameHasEnded = true;
            Debug.Log("Game Kalah");
            UIGameover.SetActive(true);
            scoreGameOver();
        }
    }

    private void scoreGameOver()
    {
        FindObjectOfType<ScoreManager_9>().scoreGameOver();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("Problem9");
    }
}
