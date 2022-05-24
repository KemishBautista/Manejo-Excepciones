using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--------POTENCIAS--------");
                Console.Write("Ingrese un numero entero: ");
                int Numero = int.Parse(Console.ReadLine());

                Console.WriteLine("El numero al cuadrado es: " + Math.Pow(Numero, 2));
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
            }

            catch(FormatException e)
            {
                Console.WriteLine("El valor ingresado no es un numero entero");
                Console.ReadKey();
            }
            catch(OverflowException e)
            {
                Console.WriteLine("El numero ingresado es muy grande");
                Console.ReadKey();
            }
        }
    }
}
