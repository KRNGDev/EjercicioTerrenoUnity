using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class Enemigo : MonoBehaviour
{

    public float velRotate = 200.0f;
    public float velMovimiento = 5.0f;
    public float minAngle;
    public float maxAngle;
    public GameObject suelo;
    public Animator animator;
    public float x, y;
    private GameObject enemi;
    private Rigidbody rbEnemi;
    private int estado;
    private bool moviendose = false;
    private bool girando = false;
    private bool activo = true;

    // Start is called before the first frame update
    void Start()
    {
        enemi = GameObject.FindWithTag("Enemigo");
        rbEnemi = enemi.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        suelo = GameObject.FindWithTag("Suelo");
        StartCoroutine(ActivarMovimientos());

    }

    // Update is called once per frame
    void Update()
    {
        if (moviendose)
        {
            transform.Translate(Vector3.forward * velMovimiento * Time.deltaTime);
            x = 1;

            animator.SetFloat("X", x);
            animator.SetFloat("Y", y);
        }


        if (girando)
        {
            y = 1;
            x = 0.5f;
            transform.Rotate(Vector3.up * 90f * Time.deltaTime);
            animator.SetFloat("X", x);
            animator.SetFloat("Y", y);
        }



    }
    IEnumerator ActivarMovimientos()
    {
        Debug.Log("Se Activa el enumerator");
        while (activo)
        {
            Debug.Log("Empienza el while");
            estado = Random.Range(1, 4);
            animator.SetFloat("X", 0);
            switch (estado)
            {

                case 1:
                    moviendose = true;
                    Debug.Log(" el caso Se mueve");

                    break;
                case 2:
                    Debug.Log("Gira y avanza");
                    girando = true;
                    moviendose = false;
                    break;
                case 3:
                    Debug.Log("Quieto");
                    girando = false;
                    moviendose = false;
                    y = 0;
                    x = 0;
                    break;
                default:
                    Debug.LogError("Movimiento no reconocido");
                    break;

            }


            yield return new WaitForSeconds(3f);
        }


    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != suelo.tag)
        {

            transform.Rotate(0, Random.Range(minAngle, maxAngle), 0);

        }
    }
    void OnDestroy()
    {
        // Detiene la corutina 
        StopCoroutine(ActivarMovimientos());
    }
}
