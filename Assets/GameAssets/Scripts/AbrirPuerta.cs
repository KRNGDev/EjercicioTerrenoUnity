using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPuerta : MonoBehaviour
{

    public Animator animator;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (player != null)
        {
            ColisionadorJugador jugador = player.GetComponent<ColisionadorJugador>();
            bool llave = jugador.key;


            if (llave == true)
            {
                animator.SetTrigger("Abrir");
            }
        }

        if (other.gameObject.tag == "Player")
        {

            animator.SetTrigger("Apertura");

        }

    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            animator.SetTrigger("Cerrar");

        }


    }
}
