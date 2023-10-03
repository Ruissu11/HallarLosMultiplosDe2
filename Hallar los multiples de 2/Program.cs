using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hallar_los_multiples_de_2
{
    class Program
    {
        static void Main()
        {
            // Pedir al usuario que ingrese un número
            Console.Write("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Mostrar los múltiplos de 2 hasta el número ingresado
            Console.WriteLine("Los múltiplos de 2 hasta " + numero + " son:");

            for (int i = 2; i <= numero; i += 2)
            {
                Console.WriteLine(i);
            }

            // Esperar a que el usuario presione Enter para salir
            Console.ReadLine();
        }
    }
}
