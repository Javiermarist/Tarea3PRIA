using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // EJERCICIO B.1. Crea un cubo que se desplace en el eje X a una velocidad de 1 unidad por segundo. Al llegar a la posici�n 10, debe recolocarse en la posici�n 0.

    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);

        if (transform.position.x >= 10)
        {
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }
    }
}