using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Bucles.servicios
{
    internal interface peticionInterfaz
    {
        /// <summary>
        /// Método que pide el mes
        /// </summary>
        public int PedirMes();

        /// <summary>
        /// Método que pide el año
        /// </summary>

        public int PedirAnyo();

        /// <summary>
        /// Método que controla si se quiere repetir de nuevo la consulta
        /// </summary>

        public string RepetirFecha();
    }
}
