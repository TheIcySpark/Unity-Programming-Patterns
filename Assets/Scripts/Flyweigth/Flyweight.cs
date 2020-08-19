using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Flyweight : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabFlyweigth;
    [SerializeField]
    private GameObject prefabBruto;
    [SerializeField]
    private int n;
    [SerializeField]
    private bool modoOptimo;

    private void CreacionAleatoria(GameObject prefab, int n)
    {
        for(int i=1; i<=n; i++)
        {
            Instantiate(prefab, new Vector3(Random.Range(-10f, 10f),
                Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);
        }
    }

    private void ModoFlyweight()
    {
        CreacionAleatoria(prefabFlyweigth, n);
    }

    private void ModoBruto()
    {
        CreacionAleatoria(prefabBruto, n);
    }

    private void Start()
    {
        if (modoOptimo)
        {
            ModoFlyweight();
        }
        else
        {
            ModoBruto();
        }
    }
}