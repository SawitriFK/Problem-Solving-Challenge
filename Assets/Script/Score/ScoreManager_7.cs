using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager_7 : MonoBehaviour
{
    public static int score;
    public Text _score;

    private void OnEnable()
    {
        score = 0;
    }

    public void addScore(int amount)
    {
        score += amount;
        _score.text = score.ToString();

    }

}
