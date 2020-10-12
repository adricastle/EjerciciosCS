using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int maximo = 0;

            string linea;

            Console.WriteLine("Introduce dos numeros enteros para ver cuál de ellos es el mayor:");
            Console.WriteLine("Primer número:");
            linea = Console.ReadLine();
            a = int.Parse(linea);
            Console.WriteLine("Segundo número:");
            linea = Console.ReadLine();
            b = int.Parse(linea);
            if (b > a)
            {
                maximo = b;

            }
            else if (a > b)
            {
                maximo = a;
            }
            else if (b == a)
            {
                maximo = 0;
                
            }
            if (maximo == 0)
            {
                Console.WriteLine("Los dos numeros son iguales");
            }
            else
            {
                Console.WriteLine("El número " + maximo + " es el mayor. ");
            }
            
        }
    }
}
