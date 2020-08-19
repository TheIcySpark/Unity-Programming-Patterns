using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoEstado1 : ObjetoBaseEstado
{
    private Estados estado = Estados.idle;
    private bool limiteSalto = false;
    public override void Accionar(Transform pos)
    {
        switch (estado)
        {
            case Estados.idle:
                Debug.Log("IDLE");
                break;
            case Estados.caminar:
                Debug.Log("CAMINAR");
                pos.position += new Vector3(1, 0, 0);
                break;
            case Estados.saltar:
                Debug.Log("Saltar");
                if (!limiteSalto)
                {
                    pos.position += new Vector3(0, 0.1f, 0);
                    if (pos.position.y > 0)
                    {
                        limiteSalto = true;
                    }
                }
                else{
                    pos.position -= new Vector3(0, 0.1f, 0);
                }
                break;
        }
    }

    public override void Actualizar(KeyCode entrada, Transform pos)
    {
        switch (estado)
        {
            case Estados.idle:
                limiteSalto = false;
                if (entrada == KeyCode.RightArrow)
                {
                    estado = Estados.caminar;
                }
                else if(entrada== KeyCode.UpArrow)
                {
                    estado = Estados.saltar;
                }
                break;
            case Estados.caminar:
                if(entrada== KeyCode.None)
                {
                    estado = Estados.idle;
                }
                else if (entrada == KeyCode.UpArrow)
                {
                    estado = Estados.saltar;
                }
                break;
            case Estados.saltar:
                if (pos.position.y <= -4f)
                {
                    pos.position = new Vector3(pos.position.x, -4);
                    estado = Estados.idle;
                }
                break;
        }
        Accionar(pos);
    }
}
