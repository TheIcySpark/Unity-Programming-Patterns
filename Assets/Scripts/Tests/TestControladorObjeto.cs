using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestControladorObjeto : MonoBehaviour
{
    private Transform pos;
    private void Start()
    {
        pos = GetComponent<Transform>();
    }

    public Transform Moverderecha()
    {
        pos.position += new Vector3(1, 0, 0);
        return pos;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Moverderecha();
        }
    }
}
