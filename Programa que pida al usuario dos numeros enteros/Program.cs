using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_que_pida_al_usuario_dos_numeros_enteros
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite valor de a");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite vaalor de b");

            int b = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            
            else if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }

            else
            {
                double x = a / b;
            }

            Console.WriteLine("Presione cualquir tecla para cerrar");

            Console.ReadKey();
        }
    }
}
