using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoMovible : MonoBehaviour
{
    public void MoverDerecha()
    {
        transform.position += new Vector3(1, 0, 0);
    }

}
