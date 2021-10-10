using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController_6 : MonoBehaviour
{
    public GameObject[] box;
    public int rnd;

    void Start()
    {
        rnd = Random.Range(5, 10);
        spawnBox(rnd);
        Debug.Log(rnd);
    }

    void spawnBox(int countBox)
    {

        int prevPos = -1;
        for (int i = 0; i < countBox; i++)
        {
            if (i != prevPos)
            {
                int numListBox = Random.Range(0, box.Length);
                float spawnY = Random.Range(-3, 3);
                float spawnX = Random.Range(-7, 7);

                Vector2 spawnPosition = new Vector2(spawnX, spawnY);
                Instantiate(box[numListBox], spawnPosition, Quaternion.identity);
                prevPos = i;
            }
            //yield return new WaitForSeconds(delay);

        }
    }
}
