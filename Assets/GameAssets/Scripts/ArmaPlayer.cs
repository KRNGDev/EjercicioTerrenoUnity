using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ArmaPlayer : MonoBehaviour
{
    public Arma arma;


    public Image crossHair;
    public GameObject camara1Persona;
    public GameObject camaraPrincipal;

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
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            camaraPrincipal.SetActive(false);

            //Activa el crossHair
            crossHair.enabled = true;
            //Modifica el fieldofview de la camara
            camara1Persona.SetActive(true);
            camara1Persona.gameObject.GetComponent<Camera>().fieldOfView = 18;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            //Activa el crossHair
            crossHair.enabled = false;
            //Modifica el fieldofview de la camara
            camara1Persona.gameObject.GetComponent<Camera>().fieldOfView = 18;
            camara1Persona.SetActive(false);
            camaraPrincipal.SetActive(true);
        }

    }
    public void ApretarGatillo()
    {
        arma.IntentarDisparo();
    }

}
