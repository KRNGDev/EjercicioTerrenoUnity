using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TerrainTools;

public class AbrirPuerta : MonoBehaviour
{

    public Animator animator;
    public String nombreItemNecesario;
    public String nombreActivadorAnimacion;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //ColisionadorJugador jugador = player.GetComponent<ColisionadorJugador>();

            bool tieneItem = other.gameObject.GetComponent<Inventario>().HasItem(nombreItemNecesario);
            ItemManager item = other.gameObject.GetComponent<ItemManager>();
            Inventario inventario = other.gameObject.GetComponent<Inventario>();


            if (tieneItem)
            {
                animator.SetTrigger(nombreActivadorAnimacion);

                inventario.GetItem(nombreItemNecesario);
                //Activa la animacion
                switch (nombreItemNecesario)
                {
                    case "Llave":
                        item.imgLlave.SetActive(false);
                        break;

                    case "Pocion":
                        item.imgPocion.SetActive(false);
                        break;

                    case "Comida":
                        item.imgComida.SetActive(false);
                        break;

                    default:
                        print("no hay nada");
                        break;
                }




            }
            print("No tiene objeto");
            /* switch (tieneItem)
         {
             case "Llave":

                 animator.SetTrigger("Abrir");
                 item.SetActive(false);
                 //Falta quitar llave del inventario
                 break;

             case "Pocion":


                 break;

             case "Comida":


                 break;

             default:
                 print("no hay nada");
                 break;
         }*/
        }

        /* if (other.gameObject.CompareTag("Player"))
         {

             animator.SetTrigger("Apertura");

         }*/

    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {

            animator.SetTrigger("Cerrar");

        }


    }
}
