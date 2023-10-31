using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Bucles.servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public void AñoBisiesto(int mes, int anyo)
        {
            
            
                if (anyo % 4 == 0)
                {
                    if (anyo % 100 == 0)
                    {
                        if (anyo % 400 == 0)
                        {
                            Console.WriteLine("El mes de Febrero tiene 29 dias");
                        }

                        else
                        {
                            Console.WriteLine("El mes de Febrero tiene 28 dias");
                        }
                    }

                    else
                    {
                        Console.WriteLine("El mes de Febrero tiene 29 dias");
                    }
                }

                else
                {
                    Console.WriteLine("El mes de Febrero tiene 28 dias");
                }
            
            
            
            
        }
    }
}
