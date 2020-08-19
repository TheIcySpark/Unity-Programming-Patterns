using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInputSingleton : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            ControladorSingleton.GcontroladorSingleton.AumentarN();
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            ControladorSingleton.GcontroladorSingleton.AumentarV();
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            ControladorSingleton.GcontroladorSingleton.ImprimirN();
            ControladorSingleton.GcontroladorSingleton.ImprimirV();
        }
    }
}
