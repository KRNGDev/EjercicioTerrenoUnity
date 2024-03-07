using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionadorJugador : MonoBehaviour
{
    public GameObject boton;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Puerta"))
        {
            boton.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Puerta"))
        {
            boton.SetActive(false);
        }
    }
}
