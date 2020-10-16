using System;
using System.Linq.Expressions;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            double division = 0;

            Console.WriteLine("Hola, Introduce dos numeros enteros a y b para dividir a entre b:");
            try
            {
                Console.WriteLine("Primer número");
                string line = Console.ReadLine();
                a = int.Parse(line);

                Console.WriteLine("Segundo número");
                line = Console.ReadLine();
                b = int.Parse(line);

                division = a / b;

                Console.WriteLine("La división de " + a + " entre " + b  + " es:" + division);

            }
            catch (FormatException e)
            {
                Console.WriteLine("el valor debe ser un entero");
          
            }
            catch (OverflowException o)
            {
                Console.WriteLine("no puede ser un numero muy grande");
            }
            catch (DivideByZeroException d)
            {

                Console.WriteLine("divisor no puede ser > 0 ");
            }
            

        }
    }
}
