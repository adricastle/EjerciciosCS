using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_sietes = 0;
             
            int introducido = 0;
            bool exit = false;
            int n_numeros = 0;

            Console.WriteLine("Introduce una serie de números enteros (10 como máximo) y se va a calcular el numero de veces que introduces el número 7");

            do
            {
                
                Console.WriteLine("Introduzca numero:(-1 para salir)");
                string line;
                line = Console.ReadLine();
                introducido = int.Parse(line);

                if (introducido == -1)
                {
                    exit = true;
                    
                }

                if (introducido == 7)
                {
                    n_sietes++;
                }

                n_numeros++;
            } while ((exit==false) && (n_numeros < 10));

            Console.WriteLine("Número de sietes: " + n_sietes + "\n");




        }
    }
}
