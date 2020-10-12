using System;
using System.Security.Cryptography;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int x = 0;
            int introducido = 0;
            bool adivinado = false;
            //genero numero aleatorio entre 0 y 20
            x = aleatorio.Next(0, 20);
            Console.WriteLine("Hola, escribe un numero entero de 0 al 20 para adivinar el número generado. " + "\n Tienes 5 intentos:" );
            //introduzco 5 valores
            for (int i=0; (i<5) && (adivinado == false); i++)
            {
                Console.WriteLine("Escribe un número a adivinar:");
                string line;
                line = Console.ReadLine();
                introducido = int.Parse(line);
                if(introducido < x)
                {
                    Console.WriteLine("El número " + introducido + " es menor que el número a adivinar.");
                }
                if (introducido > x)
                {
                    Console.WriteLine("El número " + introducido + " es mayor que el número a adivinar.");
                }
                if (introducido==x)
                {
                    Console.WriteLine("¡¡Enorabuena lo has adivinado!!");
                    adivinado = true;
                }
                Console.WriteLine("Número de intentos:" + (i+1));

            }
        }
    }
}
