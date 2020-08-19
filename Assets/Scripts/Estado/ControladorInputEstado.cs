using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInputEstado : MonoBehaviour
{
    [SerializeField] private GameObject objeto1;
    private Transform pos1;
    private ObjetoEstado1 estado1;

    private void Start()
    {
        pos1 = objeto1.GetComponent<Transform>();
        estado1 = objeto1.GetComponent<ObjetoEstado1>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            estado1.Actualizar(KeyCode.RightArrow, pos1);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            estado1.Actualizar(KeyCode.UpArrow, pos1);
        }
        else
        {
            estado1.Actualizar(KeyCode.None, pos1);
        }
    }
}
