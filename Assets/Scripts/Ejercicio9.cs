using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    // EJERCICIO B.9. Crea un cubo que se desactive entre tres y cinco segundos después de clicar en él.

    void OnMouseDown()
    {
        float delay = Random.Range(3f, 5f);
        StartCoroutine(DesactivateAfterDelay(delay));
    }

    IEnumerator DesactivateAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }
}
