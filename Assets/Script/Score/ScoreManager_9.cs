using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager_9 : MonoBehaviour
{
    public static int score;
    public Text _score;
    public Text _scoreGameOver;

    public GameObject _GameController;
    private GameController script;

    void Start()
    {
        script = _GameController.GetComponent<GameController>();
    }

    private void OnEnable()
    {
        score = 0;
    }

    public void addScore(int amount)
    {
        //Debug.Log(script.gameHasEnded);
        if (script.gameHasEnded == false)
        {
            score += amount;
            _score.text = score.ToString();
        }

    }

    public void scoreGameOver()
    {
        _scoreGameOver.text = "SCORE : " + score.ToString();
    }
}
