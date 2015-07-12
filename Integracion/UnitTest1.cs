using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorio1.Integral;

namespace Integracion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaIntegracion()
        {
            Laboratorio1.Integral.Integracion integral = new Laboratorio1.Integral.Integracion();

            double valorA = 5;
            double VAlorB = 10;
            double valorK = 1;
            double valorN=2;
            int tipo = 1;
            double res = 5;

            Assert.IsTrue(res== integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo));
                       
        }
    }
}
