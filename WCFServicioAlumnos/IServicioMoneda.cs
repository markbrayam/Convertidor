using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioConvertidor
{
    [ServiceContract]
    interface IServicioMoneda
    {
        [OperationContract]
        float farenheitACelcius(float farenheit);
        [OperationContract]
        float celciusAFarenheit(float celcius);
    }
}
