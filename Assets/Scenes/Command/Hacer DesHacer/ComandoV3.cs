using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NComandoV3
{
    public abstract class ComandoV3
    {
        public abstract void Hacer(ControladorObjeto controladorObjeto, Vector3 pos);
        public abstract void Deshacer(ControladorObjeto controladorObjeto);
    }

    public class ComandoMoverV3: ComandoV3
    {
        public Vector3 posicion;
        public override void Hacer(ControladorObjeto controladorObjeto, Vector3 pos)
        {
            posicion = pos;
            controladorObjeto.Mover(pos);
        }

        public override void Deshacer(ControladorObjeto controladorObjeto)
        {
            controladorObjeto.Mover(-posicion);
        }
    }
}

