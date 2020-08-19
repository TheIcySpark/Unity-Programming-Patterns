using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComandoMoverV2 : ComandoMultiplesObjetos
{
    public override void Ejecutar(ObjetoMovible objeto)
    {
        objeto.MoverDerecha();
    }
}
