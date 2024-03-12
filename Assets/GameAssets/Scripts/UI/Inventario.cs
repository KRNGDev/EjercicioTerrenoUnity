using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public List<String> items;
    public void addItem(GameObject item)
    {
        items.Add(item.name);
    }

    public bool HasItem(string nombre)
    {
        foreach (string item in items)
        {
            if (item == nombre)
            {
                return true;
            }

        }
        return false;
    }

}
