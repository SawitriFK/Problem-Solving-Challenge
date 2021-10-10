using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rigid2d;
    void Start()
    {
        //lingkaran bergerak dengan suatu kecepatan konstan sehingga keluar dari layar
        rigid2d = GetComponent<Rigidbody2D>();
        rigid2d.velocity = new Vector2(2f, 2f);
    }
}
