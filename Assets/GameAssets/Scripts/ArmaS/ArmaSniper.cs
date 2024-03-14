using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSniper : MonoBehaviour
{
    public int capacidadCargador = 100;
    public int municion = 0;

    public Transform transforEmisor;
    public Transform transformOrigenRaycast;
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
        RaycastHit hitInfo;
        bool hayImpacto = Physics.Raycast(transformOrigenRaycast.position, transformOrigenRaycast.forward, out hitInfo);
        if (hayImpacto)
        {
            if (hitInfo.transform.CompareTag("Enemigo"))
            {
                hitInfo.transform.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
                hitInfo.transform.GetComponentInChildren<Rigidbody>().AddForce(Vector3.up * fuerzaDisparo);

            }
        }


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
