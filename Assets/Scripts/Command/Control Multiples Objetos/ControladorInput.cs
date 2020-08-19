using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInput : MonoBehaviour
{
    private ComandoMoverV2 comando= new ComandoMoverV2();
    private GameObject[] objetos;

    private void Start()
    {
        objetos = GameObject.FindGameObjectsWithTag("Objeto");
    }

    private void Update()
    {
        int i = -1;
        if (Input.GetKeyDown(KeyCode.A))
        {
            i = 0;
        } else if (Input.GetKeyDown(KeyCode.B))
        {
            i = 1;
        }else if (Input.GetKeyDown(KeyCode.C))
        {
            i = 2;
        }else if (Input.GetKeyDown(KeyCode.D))
        {
            i = 3;
        }
        if (i != -1)
        {
            objetos = GameObject.FindGameObjectsWithTag("Objeto");
            ObjetoMovible script = objetos[i].GetComponent<ObjetoMovible>();
            if (script == null) Debug.LogError("El objeto no tiene el script: ObjetoMovible");
            comando.Ejecutar(script);
        }
    }
}
