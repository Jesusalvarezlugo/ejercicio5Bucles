using ejercicio5Bucles.servicios;
using System.Timers;

namespace ejercicio5Bucles.controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            int anyo;
            string respuesta;

            peticionInterfaz pi = new peticionImplementacion();
            operacionesInterfaz oi = new operacionesImplementacion();

            do
            {
                mes = pi.PedirMes();
                anyo = pi.PedirAnyo();

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("El mes de Enero tiene 31 días");
                        break;

                    case 2:
                        oi.AñoBisiesto(mes,anyo);
                        break;

                    case 3:
                        Console.WriteLine("El mes de Marzo tiene 31 días");
                        break;

                    case 4:
                        Console.WriteLine("El mes de Abril tiene 30 días");
                        break;

                    case 5:
                        Console.WriteLine("El mes de Mayo tiene 31 días ");
                        break;

                    case 6:
                        Console.WriteLine("El mes de Junio tiene 30 días");
                        break;

                    case 7:
                        Console.WriteLine("El mes de Julio tiene 31 días");
                        break;

                    case 8:
                        Console.WriteLine("El mes de Agosto tiene 31 días");
                        break;

                    case 9:
                        Console.WriteLine("El mes de Septiembre tiene 30 días");
                        break;

                    case 10:
                        Console.WriteLine("El mes de Octubre tiene 31 días");
                        break;

                    case 11:
                        Console.WriteLine("El mes de Noviembre tiene 30 días");
                        break;

                    case 12:
                        Console.WriteLine("El mes de Diciembre tiene 31 días");
                        break;

                    default:
                        Console.WriteLine("[ERROR] el numero introducido no es un mes");
                        break;

                }
                respuesta = pi.RepetirFecha();
            } while (respuesta=="s");
        }
    }
}
