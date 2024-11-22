using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    // EJERCICIO B.6. Crea un objeto que se desplace en el eje Z una unidad al soltar la tecla espaciadora.

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0, 1);
        }
    }
}
