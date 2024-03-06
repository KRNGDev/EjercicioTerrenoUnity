using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject botonMenu;
    public void ActivarPanel()
    {
        panelMenu.SetActive(true);
        botonMenu.SetActive(false);
    }
    public void OcultarPanel()
    {
        panelMenu.SetActive(false);
        botonMenu.SetActive(true);
    }
    public void EjecutarLoadScene()
    {
        StartCoroutine(EsperarLoadScene());
    }
    public void EjecutarMenuPrincipal()
    {
        StartCoroutine(EsperarMenuPrincipal());
    }

    public IEnumerator EsperarLoadScene()
    {
        // Esperar 2 segundos
        yield return new WaitForSeconds(0.5f);

        // Llamar a la función que deseas activar 
        LoadScene();
    }
    IEnumerator EsperarMenuPrincipal()
    {
        // Esperar 2 segundos
        yield return new WaitForSeconds(1);

        // Llamar a la función que deseas activar 
        MenuPrincipal();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Exterior");
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Intro");

    }
    public void Salir()
    {
        Application.Quit();
    }
}
