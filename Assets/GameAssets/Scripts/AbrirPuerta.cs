using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TerrainTools;

public class AbrirPuerta : MonoBehaviour
{

    public Animator animator;
    public String nombreItemNecesario;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //ColisionadorJugador jugador = player.GetComponent<ColisionadorJugador>();

            bool tienellave = other.gameObject.GetComponent<Inventario>().HasItem(nombreItemNecesario);


            if (tienellave)
            {
                animator.SetTrigger("Abrir");
            }
        }

        if (other.gameObject.CompareTag("Player"))
        {

            animator.SetTrigger("Apertura");

        }

    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            animator.SetTrigger("Cerrar");

        }


    }
}
