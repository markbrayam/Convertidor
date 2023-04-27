using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServicioAlumnos
{
    [ServiceContract]
    internal interface IServicioClima
    {
        [OperationContract]
        float dolaresAPesos (float dolares);
        [OperationContract]
        float pesosADolares(float pesos);
    }
}
