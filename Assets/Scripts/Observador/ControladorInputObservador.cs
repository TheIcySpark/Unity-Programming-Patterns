using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInputObservador : MonoBehaviour
{
    public delegate void CambiarSprite(Sprite sprite);
    public event CambiarSprite EspacioPresionado;
    [SerializeField]
    private Sprite sprite;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (EspacioPresionado != null)
            {
                EspacioPresionado(sprite);
            }
        }
    }
}
