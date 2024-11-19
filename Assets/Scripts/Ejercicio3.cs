using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    // EJERCICIO B.3. Haz que un cubo aumente la escala si mantenemos pulsada la tecla espaciadora y la disminuya si no la pulsamos. La escala mínima debe ser 1 en cada eje.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += new Vector3(0.2f, 0.2f, 0.2f) * Time.deltaTime;
        }
        else
        {
            transform.localScale -= new Vector3(0.2f, 0.2f, 0.2f) * Time.deltaTime;
            transform.localScale = new Vector3(
                Mathf.Max(1, transform.localScale.x),
                Mathf.Max(1, transform.localScale.y),
                Mathf.Max(1, transform.localScale.z)
            );
        }
    }
}
