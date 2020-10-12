using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            

            bool esPar = false;

            Console.WriteLine("Escriba dos números enteros para ver si son pares o no:");
            Console.WriteLine("Primer número:");
            string line;
            line = Console.ReadLine();
            x = int.Parse(line);
            Console.WriteLine("Segundo número:");
            line = Console.ReadLine();
            y = int.Parse(line);

            //compromabos para x si es par
            if((x % 2) == 0)
            {
                esPar = true;
                Console.WriteLine("El número " + x + " es Par");
            }
            else if ((x % 2) != 0)
            {
                esPar = false;
                Console.WriteLine("El número " + x + " es Impar");
            }

            //compromabos para y si es par
            if ((y % 2) == 0)
            {
                esPar = true;
                Console.WriteLine("El número " + y + " es Par");
            }
            else if ((y % 2) != 0)
            {
                esPar = false;
                Console.WriteLine("El número " + y + " es Impar");
            }


        }
    }
}
