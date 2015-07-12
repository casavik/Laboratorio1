using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Laboratorio1.Integral;

namespace WcfIntegral
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double ResolverIntegral(double valorA, double valorB, double valorK, double valorN, int tipo)
        {
            Integracion integral = new Integracion(valorA, valorB, valorK, valorN, tipo);
            integral.ResolverIntegral(valorA, valorB, valorK, valorN, tipo);
            return (integral.valorResultado);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        Integracion IService1.ResolverIntegral(double valorA, double valorB, double valorK, double valorN, int tipo)
        {
            throw new NotImplementedException();
        }
    }
}
