using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFServicioAlumnos
{
    internal class ServicioMoneda : IServicioClima
    {
        
        public float dolaresAPesos(float dolares)
        {
            float pesos = dolares / 18;
            return pesos;
        }

        public float pesosADolares(float pesos)
        {
            float dolares = pesos * 18;
            return dolares;
        }
    }
}
