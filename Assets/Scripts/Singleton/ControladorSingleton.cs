using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorSingleton : MonoBehaviour
{
    public static ControladorSingleton GcontroladorSingleton;

    private static int n = 0;

    private static int v = 0;


    private void Awake()
    {
        GcontroladorSingleton = this;
    }


    public void AumentarN()
    {
        n++;
    }

    public void AumentarV()
    {
        v++;
    }

    public void ImprimirN()
    {
        Debug.Log(n);
    }

    public void ImprimirV()
    {
        Debug.Log(v);
    }
}
