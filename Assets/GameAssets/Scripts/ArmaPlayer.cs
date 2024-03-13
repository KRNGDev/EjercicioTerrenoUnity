using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaPlayer : MonoBehaviour
{
    public Arma arma;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {

            ApretarGatillo();

        }
        else if (Input.GetKeyDown(KeyCode.R))
        {

            arma.Reload();
        }
    }
    public void ApretarGatillo()
    {
        arma.IntentarDisparo();
    }

}
