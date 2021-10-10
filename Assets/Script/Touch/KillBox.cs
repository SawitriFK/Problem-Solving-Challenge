using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    [SerializeField ]private GameObject script;


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
        if (script.GetComponent("ScoreManager_7"))
        {
            Debug.Log("Masuk");
            FindObjectOfType<ScoreManager_7>().addScore(1);
        }
        if (script.GetComponent("ScoreManager_9"))
        {
            Debug.Log("Masuk");
            FindObjectOfType<ScoreManager_9>().addScore(1);
        }
    }
}
