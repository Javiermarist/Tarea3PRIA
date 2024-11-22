using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    // EJERCICIO B.5. Crea un simple controlador de personaje que desplace un cubo en los ejes X y Z al pulsar los cursores.

    public float speed = 5.0f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0.0f, moveY);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
