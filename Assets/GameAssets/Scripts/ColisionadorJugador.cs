using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionadorJugador : MonoBehaviour
{
    public GameObject boton;
    public GameObject mensajeKey;
    public GameObject consegirKey;
    public Boolean key = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Puerta") && key == true)
        {
            boton.SetActive(true);
        }
        else if (other.CompareTag("Key"))
        {
            key = true;
            consegirKey.SetActive(true);
            Destroy(other.gameObject);
        }
        else
        {
            mensajeKey.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Puerta"))
        {
            boton.SetActive(false);
            mensajeKey.SetActive(false);
        }
    }

}
