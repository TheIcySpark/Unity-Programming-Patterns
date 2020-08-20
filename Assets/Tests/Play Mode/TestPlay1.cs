using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestPlay1
    {
        [UnityTest]
        public IEnumerator TestMoverDerecha()
        {
            GameObject objeto = new GameObject();
            TestControladorObjeto controlador = objeto.AddComponent<TestControladorObjeto>();
            yield return new WaitForSeconds(1.0f); ///Esperar a que se llame start
            Transform pos = controlador.Moverderecha();

            yield return new WaitForSeconds(1);

            Assert.AreEqual(new Vector3(1,0,0), pos.position);
        }
    }
}
