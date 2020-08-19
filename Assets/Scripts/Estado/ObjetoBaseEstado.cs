using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoBaseEstado: MonoBehaviour
{
    protected enum Estados
    {
        saltar,
        idle,
        caminar
    }

    public virtual void Actualizar(KeyCode entrada, Transform pos)
    {

    }

    public virtual void Accionar(Transform pos)
    {

    }
}
