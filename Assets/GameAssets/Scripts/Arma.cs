using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Arma : MonoBehaviour
{
    public int capacidadCargador = 100;
    public int municion = 0;
    public GameObject prfabBala;
    public Transform transforEmisor;
    public float fuerzaDisparo = 50.0f;
    public void IntentarDisparo()
    {
        if (municion > 0)
        {

            Disparar();
        }

    }
    public void Disparar()
    {
        municion--;
        GameObject bala = Instantiate(prfabBala, transforEmisor.position, transforEmisor.rotation);
        bala.GetComponent<Rigidbody>().AddForce(bala.transform.forward * fuerzaDisparo);

    }
    public void Reload()
    {
        municion = capacidadCargador;

    }

}
