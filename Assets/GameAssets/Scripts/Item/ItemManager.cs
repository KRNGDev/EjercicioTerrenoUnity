using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject imagenLlave;
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "LlavePoder")
        {

            //1. Desaparece la llave
            Destroy(c.gameObject);

            //2. Aparece en la interfaz de usuario
            imagenLlave.SetActive(true);

            //3. Añadimos al inventario
            GetComponent<Inventario>().addItem(c.gameObject);//Añadir la llave al inventario
        }
    }
}
