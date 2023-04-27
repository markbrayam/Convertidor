using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioConvertidor
{
    public class ServicioClima : IServicioMoneda
    {
        public float celciusAFarenheit(float celcius)
        {
            float farenheit = celcius * 9 / 5;
            farenheit = farenheit + 32;
            return farenheit;
        }

        public float farenheitACelcius(float farenheit)
        {
            float celcius = farenheit - 32;
            celcius = celcius * 9 / 5; 
            return celcius;
        }
    }
}
