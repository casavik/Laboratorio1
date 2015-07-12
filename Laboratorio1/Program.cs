using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Laboratorio1.Integral
{
    class Program
    {
        static void Main(string[] args)
        {
           Integracion integra = new Integracion();

           double valorA = 5.0;
           double VAlorB = 10.0;
           double valorK = 450.0;
           double valorN = 10.0;
           int tipo = 7;
           double res = 0.0;

           double result = Math.Sin(40);
            res = integra.ResolverIntegral(valorA, VAlorB, valorK, valorN, tipo);
            double numero = Math.Round(res, 4);
            double resuktado = 1.3;
            double resuktad = 1.3;
        }
    }
}
