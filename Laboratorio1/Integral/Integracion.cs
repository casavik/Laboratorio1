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

        public Integracion()
        {
            valorA = 0;
            valorB = 0;
            valorK = 0;
            //tipo = 0;
        }
        public Integracion(double a, double b, double k, double tipo)
        {
            valorA = a;
            valorB = b;
            valorK = k;
            tipo = 0;
        }

        public Integracion(double a, double b, double k, double n, double tipo)
        {
            valorA = a;
            valorB = b;
            valorK = k;
            valorN = n;
            tipo = 0;
        }

        public double ResolverIntegral(double a, double b, double k, double n, int tipo){

            switch (tipo)
            {
                case 1:
                    ObtenerSoluciones();
                    return IntegrarSimple();
                    break;

                case 2:
                    ObtenerSoluciones();
                    return IntegrarConstante();
                    break;

                case 3:
                    ObtenerSoluciones();
                    return IntegrarPotencia();
                    break;

                case 4:
                    ObtenerSoluciones();
                    return IntegrarLogaritmo();
                    break;

                case 5:
                    ObtenerSoluciones();
                    return IntegrarExponencial();
                    break;

                case 6:
                    ObtenerSoluciones();
                    return IntegrarSeno();
                    break;

                case 7:
                    ObtenerSoluciones();
                    return IntegrarCoseno();
                    break;

                default:
                 return 0.0;
            }

        }

        

        public bool verificarLimites ()
        {
            bool result;
            result = (valorA < valorB);
            return result;
        }

        private double IntegrarSimple()
        {
            resultado = (valorB - valorA);
            return resultado;
        }

        private double IntegrarConstante()
        {
            resultado = ((valorK) * (valorB - valorA));
            return resultado;
        }

        private double IntegrarPotencia()
        {
            resultado = (Math.Pow(valorK, n + 1)) / (n + 1);
            return resultado;
        }

        private double IntegrarLogaritmo()
        {
            resultado = Math.Log(ValorAbsoluto(), Math.E);
            return resultado;
        }

        private double IntegrarExponencial()
        {
            resultado = Math.Pow(Math.E, valorN);
            return resultado;
        }

        private double IntegrarSeno()
        {
            resultado = (Math.Cos(valorK) *(-1));
            return resultado;
        }

        private double IntegrarCoseno()
        {
            resultado = Math.Sin(valorK);
            return resultado;
        }

        private void ObtenerSoluciones()
        {
            if (verificarLimites())
                throw new Exception("El valor de A es mayor a el valor de B");
        }

        private double ValorAbsoluto()
        {
            if (valorK < 0)
            {
                valorK= valorK * (-1);
            }
            return valorK;
        }
    }
}
