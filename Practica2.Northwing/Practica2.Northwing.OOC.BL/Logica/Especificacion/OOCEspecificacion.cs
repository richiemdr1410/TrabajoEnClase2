using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica2.Northwing.OOC.BL.Logica.Especificacion
{
    public class OOCEspecificacion
    {
        public List<Practica2.Northwind.OOC.Model.Order_Details> FacturasEntreCiertoMounto(decimal PrimerMonto, decimal SegundoMonto)
        {
            throw new NotImplementedException();
        }

        public List<Practica2.Northwind.OOC.Model.Order_Details> FacturasPorIdArticulo(int ProductID)
        {
            throw new NotImplementedException();
        }

        public List<Practica2.Northwind.OOC.Model.Customers> FacturasPorNombreAproximado(string Nombre)
        {
            throw new NotImplementedException();
        }

        public List<Practica2.Northwind.OOC.Model.Orders> FacturasPorRangoFecha(DateTime? fechaInicial, DateTime? FechaFinal)
        {
            throw new NotImplementedException();
        }
    }
}