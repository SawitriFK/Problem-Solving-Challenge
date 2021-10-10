using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {

            Destroy(this.gameObject);
        }
    }

}
