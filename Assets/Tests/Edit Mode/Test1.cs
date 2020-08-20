using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Test1
    {
        [Test]
        public void TestSuma()
        {
            ClaseSuma clase = new ClaseSuma();
            int suma = clase.Suma(10, 20);
            Assert.AreEqual(30, suma);
        }
        
    }
}
