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
        /// 06112023- jal
        /// </summary>
        public int PedirMes();

        /// <summary>
        /// Método que pide el año
        /// 06112023- jal
        /// </summary>

        public int PedirAnyo();

        /// <summary>
        /// Método que controla si se quiere repetir de nuevo la consulta
        /// 06112023- jal
        /// </summary>

        public string RepetirFecha();
    }
}
