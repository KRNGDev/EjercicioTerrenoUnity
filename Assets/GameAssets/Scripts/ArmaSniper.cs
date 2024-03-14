using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSniper : MonoBehaviour
{
    public int capacidadCargador = 100;
    public int municion = 0;
    public GameObject prfabBala;
    public Transform transforEmisor;
    public Transform transformOrigendelRaycast;
    public float fuerzaDisparo = 50.0f;
    public AudioClip audioSinBalas;
    public AudioClip audioDisparo;
    public AudioClip audioReload;
    public void IntentarDisparo()
    {
        if (municion > 0)
        {
            Disparar();
        }
        else
        {
            if (audioSinBalas != null)
            {
                GetComponent<AudioSource>().PlayOneShot(audioSinBalas);
            }

        }

    }
    public void Disparar()
    {
        municion--;

        Physics.Raycast(transformOrigendelRaycast.position, transformOrigendelRaycast.forward, out hit);
        if (audioDisparo != null)
        {
            GetComponent<AudioSource>().PlayOneShot(audioDisparo);
        }

    }
    public void Reload()
    {
        if (audioReload != null)
        {
            GetComponent<AudioSource>().PlayOneShot(audioReload);
        }

        municion = capacidadCargador;

    }
}
