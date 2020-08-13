using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorObjeto : MonoBehaviour
{
    public void Mover(Vector3 pos)
    {
        transform.position += pos;
    }
}
