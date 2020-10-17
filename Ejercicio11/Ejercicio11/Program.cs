using System;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string preg1 = "¿Cuál es el río más caudaloso del mundo?";
            string preg2 = "¿La capital de España es:?";
            string preg3 = "¿Quién es la mejor profesora de 2ºDAM?";

            string resp1 = "Amazonas";
            string resp2 = "Madrid";
            string resp3 = "Laura";
            string[] preguntas = new[] { preg1, preg2, preg3};
            string[] respuestas = new string[] { resp1, resp2, resp3};
            int score = 0;


            Console.WriteLine("Hola a continuacion se le van a mostrar 3 preguntas y tiene que responder a cada una, si aciertas ganas 2 puntos, si fallas pierdes 1 punto:");

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(preguntas[i]);
                
                string line = Console.ReadLine();
                if (line == respuestas[i])
                {
                    Console.WriteLine("Enorabuena, has ganado 2 puntos");
                    score = score + 2;
                }
                else
                {
                    Console.WriteLine("respuesta errónea, has perdido 1 punto");
                    score = score -1;
                    Console.WriteLine("La respuesta era: " + respuestas[i]);
                }
                
            }

            Console.WriteLine("Su puntuación total es: " + score);










        }
    }
}
