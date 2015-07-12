using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Integral
{
    public class Integracion
    {
        double a, b, k, n, resultado;
        int tipo;

        public double valorA
        {
            get
            { return a; }

            set { a = valorA; }
        }

        public double valorB
        {
            get
            { return b; }

            set { b = valorB; }
        }

        public double valorK
        {
            get
            { return k; }

            set { k = valorK; }
        }

        public double valorN
        {
            get
            { return n; }

            set { n = valorN; }
        }

        public double valorResultado
        {
            get
            { return resultado; }

            set { resultado = valorResultado; }
        }

        public int tipoR
        {
            get
            { return tipo; }

            set { tipo = tipoR; }
        }

        public Integracion()
        {
            valorA = 0;
            valorB = 0;
            valorK = 0;
            tipo = 0;
        }
        public Integracion(double a, double b, double k, int tipo)
        {
            valorA = a;
            valorB = b;
            valorK = k;
            tipo = 0;
        }

        public Integracion(double a, double b, double k, double n, int tipor)
        {
            valorA = a;
            valorB = b;
            valorK = k;
            valorN = n;
            tipo = tipor;
        }

        public double ResolverIntegral(double a, double b, double k, double n, int tipo){

            switch (tipo)
            {
                case 1:
                    ObtenerSoluciones(a,b);
                    return IntegrarSimple(a,b);
                    break;

                case 2:
                    ObtenerSoluciones(a,b);
                    return IntegrarConstante(a,b,k);
                    break;

                case 3:
                    ObtenerSoluciones(a,b);
                    return IntegrarPotencia(a,b,k,n);
                    break;

                case 4:
                    ObtenerSoluciones(a,b);
                    return IntegrarLogaritmo(k);
                    break;

                case 5:
                    ObtenerSoluciones(a,b);
                    return IntegrarExponencial(n);
                    break;

                case 6:
                    ObtenerSoluciones(a,b);
                    return IntegrarSeno(k);
                    break;

                case 7:
                    ObtenerSoluciones(a,b);
                    return IntegrarCoseno(k);
                    break;

                default:
                 return 0.0;
            }

        }

       
        private double IntegrarSimple(double valorA, double valorB)
        {
            resultado = (valorB - valorA);
            return resultado;
        }

        private double IntegrarConstante(double valorA, double valorB,double valorK)
        {
            resultado = ((valorK) * (valorB - valorA));
            return resultado;
        }

        private double IntegrarPotencia(double valorA, double valorB, double valorK, double valorN)
        {
            resultado = (Math.Pow(valorK, valorN + 1)) / (valorN + 1);
            return resultado;
        }

        private double IntegrarLogaritmo(double valorK)
        {
            resultado = Math.Log(ValorAbsoluto(valorK), Math.E);
            return resultado;
        }

        private double IntegrarExponencial(double valorN)
        {
            resultado = Math.Pow(Math.E, valorN);
            return resultado;
        }

        private double IntegrarSeno(double valorK)
        {
            double y = valorK * Math.PI / 180.0;
            resultado = (Math.Cos(y) *(-1));
            return resultado;
        }

        private double IntegrarCoseno(double valorK)
        {
            double y = valorK * Math.PI / 180.0;
            resultado = Math.Sin(y);
            return resultado;
        }

        private void ObtenerSoluciones(double valorA, double valorB)
        {
            if (!verificarLimites(valorA,valorB))
                throw new Exception("El valor de A es mayor a el valor de B");
        }


        public bool verificarLimites(double valorA, double valorB)
        {
            bool result;
            result = (valorA < valorB);
            return result;
        }

        private double ValorAbsoluto(double valorK)
        {
            if (valorK < 0)
            {
                valorK= valorK * (-1);
            }
            return valorK;
        }
    }
}
