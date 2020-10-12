using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 2;

            int suma = 0;
            int resta = 0;
            int multiplicacion = 0;
            int division = 0;
            int modulo = 0;

            suma = a + b;
            resta = a - b;
            multiplicacion = a * b;
            division = a / b;
            modulo = a % b;

            Console.WriteLine("Dado dos numeros enteros a:" + a + " y b:" + b);
            Console.WriteLine("La suma de ambos es igual a " + suma);
            Console.WriteLine("La resta de a - b = " + resta);
            Console.WriteLine("La multiplicación de A x b = " + multiplicacion);
            Console.WriteLine("La división de a / b = " + division);
            Console.WriteLine("El módulo de a entre b = " + modulo);
        }
    }
}
