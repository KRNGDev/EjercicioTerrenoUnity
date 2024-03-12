using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject imgLlave;
    public GameObject imgPocion;
    public GameObject imgComida;


    void OnTriggerEnter(Collider other)
    {
        /* if (other.gameObject.name == "LlavePoder")
         {

             //1. Desaparece la llave
             Destroy(other.gameObject);

             //2. Aparece en la interfaz de usuario
             // imagenLlave.SetActive(true);

             //3. Añadimos al inventario
             GetComponent<Inventario>().addItem(other.gameObject);//Añadir la llave al inventario
         }*/

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
    }
}
