using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    // EJERCICIO B.4. Crea un cubo que se desplace uniformemente entre x=0 y x=10. Debe ir y volver continuamente.

    private bool movingRight = true;

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            if (transform.position.x >= 10)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            if (transform.position.x <= 0)
            {
                movingRight = true;
            }
        }
    }
}
