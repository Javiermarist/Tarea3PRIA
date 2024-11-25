using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    // EJERCICIO B.10. Crea un cubo que cambie de nombre para indicar cuántas veces has clicado en otro cubo.

    public GameObject cube;
    public GameObject contador;
    private int clickCount = 0;

    void Start()
    {
        cube = GameObject.Find("Cube");
        contador = GameObject.Find("Contador");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Cube")
                {
                    clickCount++;
                    contador.name = clickCount.ToString();
                }
            }
        }
    }
}
