using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Practica2.Northwind.OOC.Model;

namespace Practica2.Northwing.OOC.BL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioWcfOOC : InterfaceOOC
    {
        public List<Order_Details> FacturasEntreCiertoMounto(decimal PrimerMonto, decimal SegundoMonto)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> FacturasPorIdArticulo(int ProductID)
        {
            throw new NotImplementedException();
        }

        public List<Customers> FacturasPorNombreAproximado(string Nombre)
        {
            throw new NotImplementedException();
        }

        public List<Orders> FacturasPorRangoFecha(DateTime? fechaInicial, DateTime? FechaFinal)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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
    }
}
