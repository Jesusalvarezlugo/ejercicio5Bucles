using ejercicio5Bucles.servicios;
using System.Timers;

namespace ejercicio5Bucles.controladores

///<summary>
///Clase que controla el flujo de la aplicacion
///06112023- jal
/// </summary>
{
    class Program

    ///<summary>
    ///clase desde donde iniciaremos la aplicacion
    ///06112023- jal
    /// </summary>
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

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    Console.WriteLine("el mes {0} tiene 31 días",mes);
                }else if (mes == 4 || mes == 6 || mes == 9 || mes == 10)
                {
                    Console.WriteLine("El mes {0} tiene 30 días",mes);
                }
                else
                {
                    oi.AñoBisiesto(mes,anyo);
                }
                
               
                respuesta = pi.RepetirFecha();
            } while (respuesta=="s");
        }
    }
}
