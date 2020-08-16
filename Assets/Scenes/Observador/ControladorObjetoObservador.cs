using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorObjetoObservador : MonoBehaviour
{
    [SerializeField]
    private ControladorInputObservador controladorInput;

    private void Start()
    {
        controladorInput.EspacioPresionado += CambiarSprite;
    }

    private void CambiarSprite(Sprite sprite)
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }

    private void OnDestroy()
    {
        controladorInput.EspacioPresionado -= CambiarSprite;
    }
}
