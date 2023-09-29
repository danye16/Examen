using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Examen
    {
        public void Intervalo(int numero1, int numero2)
        {
            if (numero1 == numero2)
                Console.WriteLine("Los numeros ingrersados son iguales");

            if (numero1 < numero2)
            {
                for (int c = numero1; c <= numero2; c++)
                {
                    Console.WriteLine($"La secuenta de los numeros es {c}");
                }
            }
            else if (numero1 > numero2)
            {
                for (int c = numero1; c >= numero2; c--)
                {


                    Console.WriteLine($"La secuenta de los numeros es {c}");

                }

            }
        }
    }   
}
