using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;
            int anio = 0;
            int dias = 0;

            

            Console.WriteLine("Ejercicio numero 8, después de introducir el numero del mes y el año, da como resultado el numero de días que tiene ese mes dado.");
            Console.WriteLine("Indique el mes:");

            string line;
            
            mes = int.Parse(line = Console.ReadLine());
            Console.WriteLine("Indique el año:");
            
            anio = int.Parse(line = Console.ReadLine());

            switch (mes)
            {
                case 1:
                    dias = 31;
                    break;
                case 2:
                    //si el año es bisiesto
                    if(((anio % 4 == 0) && (anio % 100 != 0)) || (anio % 400 == 0))
                    {
                        dias = 29;
                    }
                    else
                    {
                        dias = 28;
                    }
                    break;
                case 3:
                    dias = 31;
                    break;
                case 4:
                    dias = 30;
                    break;
                case 5:
                    dias = 31;
                    break;
                case 6:
                    dias = 30;
                    break;
                case 7:
                    dias = 31;
                    break;
                case 8:
                    dias = 31;
                    break;
                case 9:
                    dias = 30;
                    break;
                case 10:
                    dias = 31;
                    break;
                case 11:
                    dias = 30;
                    break;
                case 12:
                    dias = 31;
                    break;

            }

            Console.WriteLine("El mes " + mes + " del año " + anio + " tiene " + dias + " días.");

        }
    }
}
