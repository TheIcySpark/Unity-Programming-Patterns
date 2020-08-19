using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAcciones : MonoBehaviour
{
    Comando botonA;
    Comando botonB;

    private void Start()
    {
        botonA = gameObject.AddComponent<Movimiento>();
        botonB = gameObject.AddComponent<HacerNada>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            botonA.Ejecutar();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            botonB.Ejecutar();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Se intercambiaron las teclas");
            if (botonA.GetType()+"" == "Movimiento")
            {
                Destroy(botonA);
                Destroy(botonB);
                botonA = gameObject.AddComponent<HacerNada>();
                botonB = gameObject.AddComponent<Movimiento>();
            }
            else
            {
                Destroy(botonA);
                Destroy(botonB);
                botonA = gameObject.AddComponent<Movimiento>();
                botonB = gameObject.AddComponent<HacerNada>();
            }
        }
    }
}
