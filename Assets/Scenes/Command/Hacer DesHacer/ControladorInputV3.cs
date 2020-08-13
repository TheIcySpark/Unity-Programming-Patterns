using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NComandoV3;

public class ControladorInputV3 : MonoBehaviour
{
    List<ComandoMoverV3> listaComandos = new List<ComandoMoverV3>();
    GameObject objeto;
    ControladorObjeto controladorObjeto;
    ComandoMoverV3 comandoMover = new ComandoMoverV3();

    [SerializeField]
    private int indice = -1;

    public void Start()
    {
        objeto = GameObject.FindWithTag("Objeto");
        if (objeto == null) Debug.LogError("Objeto no encontrado");
        controladorObjeto = objeto.GetComponent<ControladorObjeto>();
        if (controladorObjeto == null) Debug.LogError("Objeto no tiene ControladorObjeto");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            comandoMover.Hacer(controladorObjeto, new Vector3(-1, 0, 0));
            AgregarLista();
        }else if (Input.GetKeyDown(KeyCode.W))
        {
            comandoMover.Hacer(controladorObjeto, new Vector3(0, 1, 0));
            AgregarLista();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            comandoMover.Hacer(controladorObjeto, new Vector3(1, 0, 0));
            AgregarLista();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            comandoMover.Hacer(controladorObjeto, new Vector3(0, -1, 0));
            AgregarLista();
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            RegresarLista();
        }
    }

    private void RegresarLista()
    {
        if (indice == -1) return;
        listaComandos[indice].Deshacer(controladorObjeto);
        indice--;
    }

    private bool ComandosEnfrente()
    {
        if (listaComandos.Count > indice + 1) return true;
        return false;
    }

    private void QuitarComandosEnfrente()
    {
        while (listaComandos.Count > indice + 1) listaComandos.RemoveAt(listaComandos.Count - 1);
    }

    private void AgregarLista()
    {
        if (ComandosEnfrente()) QuitarComandosEnfrente();
        ComandoMoverV3 cM = new ComandoMoverV3();
        cM.posicion = comandoMover.posicion;
        listaComandos.Add(cM);
        indice += 1;
    }
}
