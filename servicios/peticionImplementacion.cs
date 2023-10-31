using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Bucles.servicios
{
    internal class peticionImplementacion : peticionInterfaz
    {
        public int PedirAnyo()
        {
            int anyo;

            Console.WriteLine("Introduce el año: ");
            anyo = Int32.Parse(Console.ReadLine());



            return anyo;
        }

        public int PedirMes()
        {
            int mes;

            Console.WriteLine("Introduce el mes en número: ");
            mes=Int32.Parse(Console.ReadLine());

            return mes;
        }

        public string RepetirFecha()
        {
            string respuesta;

            Console.WriteLine("¿Desea hacer otra consulta de mes y año?");
            respuesta = Console.ReadLine();

            return respuesta;
        }
    }
}
