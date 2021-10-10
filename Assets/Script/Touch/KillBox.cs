using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {

            Destroy(collision.gameObject);
            // For add score
            AddScore();
        }

    }
    private void AddScore()
    {
        if (FindObjectOfType<ScoreManager_7>())
        {
            Debug.Log("Masuk");
            FindObjectOfType<ScoreManager_7>().addScore(1);
        }
    }
}
