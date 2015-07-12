using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorio1.Integral;

namespace Integra
{
    [TestClass]
    public class UnitTest1
    {
        Laboratorio1.Integral.Integracion integral = new Laboratorio1.Integral.Integracion();
        
        //prueba integral Simple
        [TestMethod]
        public void PruebaIntegracionSimple()
        {
            double valorA = 5.0;
            double VAlorB = 10.0;
            double valorK = 2.0;
            double valorN=2.0;
            int tipo = 1;
            double res = 5;
            Assert.IsTrue(res== integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo));
        }

        //prueba integral Constante
        [TestMethod]
        public void PruebaIntegracionConstante()
        {
            double valorA = 5.0;
            double VAlorB = 10.0;
            double valorK = 5.0;
            double valorN = 2.0;
            int tipo = 2;
            double res = 25;
            Assert.IsTrue(res == integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo));
        }

        //prueba integral Potencia
        [TestMethod]
        public void PruebaIntegracionPotencia()
        {
            double valorA = 5.0;
            double VAlorB = 10.0;
            double valorK = 5.0;
            double valorN = 1.0;
            int tipo = 3;
            double res = 12.5;
            Assert.IsTrue(res == integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo));
        }

        //prueba integral Logaritmo
        [TestMethod]
        public void PruebaIntegracionLogaritmo()
        {
            double valorA = 5.0;
            double VAlorB = 10.0;
            double valorK = 5.0;
            double valorN = 2.0;
            int tipo = 4;
            double res = 1.6094;
            Assert.IsTrue(res == Math.Round((integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo)),4));
        }

        //prueba integral Exponencial
        [TestMethod]
        public void PruebaIntegracionExponencial()
        {
            double valorA = 5.0;
            double VAlorB = 10.0;
            double valorK = 2.0;
            double valorN = 1.0;
            int tipo = 5;
            double res = 2.7183;
            Assert.IsTrue(res == Math.Round((integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo)), 4));
        }

        //prueba integral Seno
        [TestMethod]
        public void PruebaIntegracionSeno()
        {
            double valorA = 5.0;
            double VAlorB = 10.0;
            double valorK = 250.0;
            double valorN = 2.0;
            int tipo = 6;
            double res = 0.342;
            Assert.IsTrue(res == Math.Round((integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo)), 4));
        }

        //prueba integral Coseno
        [TestMethod]
        public void PruebaIntegracionCoseno()
        {
            double valorA = 5.0;
            double VAlorB = 10.0;
            double valorK = 450.0;
            double valorN = 2.0;
            int tipo = 7;
            double res = 1;
            Assert.IsTrue(res == Math.Round((integral.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo)), 4));
        }
    }
}
