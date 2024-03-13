using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject imgLlave;
    public GameObject imgPocion;
    public GameObject imgComida;
    public GameObject botonPuerta;

    public String itemNecesarioAccion;




    void OnTriggerEnter(Collider other)
    {
        //Para Objetos
        switch (other.gameObject.name)
        {
            case "Llave":

                GetComponent<Inventario>().addItem(other.gameObject);
                Destroy(other.gameObject);
                imgLlave.SetActive(true);
                break;

            case "Pocion":

                GetComponent<Inventario>().addItem(other.gameObject);
                Destroy(other.gameObject);
                imgPocion.SetActive(true);
                break;

            case "Comida":

                GetComponent<Inventario>().addItem(other.gameObject);
                Destroy(other.gameObject);
                imgComida.SetActive(true);
                break;

            default:
                print("no hay nada");
                break;
        }

        //Para componentes de escena
        switch (other.gameObject.tag)
        {
            case "Puerta":
                bool tieneItem = other.gameObject.GetComponent<Inventario>().HasItem(itemNecesarioAccion);
                if (tieneItem)
                    if (botonPuerta != null)
                    {
                        botonPuerta.SetActive(true);
                    }
                    else
                    {

                    }
                break;


            default:
                print("no hay nada");
                break;
        }


    }
}
