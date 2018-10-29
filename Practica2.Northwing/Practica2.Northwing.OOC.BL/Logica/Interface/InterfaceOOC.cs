using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Practica2.Northwing.OOC.BL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface InterfaceOOC
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        List<Practica2.Northwind.OOC.Model.Orders> FacturasPorRangoFecha(Nullable<System.DateTime> fechaInicial, Nullable<System.DateTime> FechaFinal );
        [OperationContract]
        List<Practica2.Northwind.OOC.Model.Customers> FacturasPorNombreAproximado(string Nombre);
        [OperationContract]
        List<Practica2.Northwind.OOC.Model.Order_Details> FacturasPorIdArticulo(int ProductID);
        [OperationContract]
        List<Practica2.Northwind.OOC.Model.Order_Details> FacturasEntreCiertoMounto(decimal PrimerMonto, decimal SegundoMonto);
        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
