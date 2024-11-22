using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    // EJERCICIO B.2. Haz que un cubo rote a la izquierda o a la derecha respondiendo a las pulsaciones del teclado correspondientes a los cursores ←, → o a las letras A y D.

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 100);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 100);
        }
    }
}