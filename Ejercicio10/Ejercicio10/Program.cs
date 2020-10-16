using System;
using System.Collections;

namespace Ejercicio10
{
    class Alumno
    {
        private string nombre;
        private int edad;


        public Alumno(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Alumno()
        {
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setEdad(int edad)
        {
            
            this.edad = edad;

        }

        public int getEdad()
        {
            return this.edad;
        }

        public void printAlumno(int i)
        {
            Console.WriteLine("Alumno " + (i+1));
            Console.WriteLine("Nombre: " + this.getNombre());
            Console.WriteLine("Edad: " + this.getEdad());
        }
        static void Main(string[] args)
        {
            int totalAlumnos = 0;
            Alumno[] listaAlumnos = new Alumno[5];

            
            bool exit = false;

            Console.WriteLine("Hola, introduce nombre y edad de 5 alumnos y se finaliza cuando se introduzca un '*'");
            
            for (int i = 0; (i<5) && (exit == false); i++)
            {
                Alumno alumno = new Alumno();

                Console.WriteLine("\nIntrodce el Nombre del alumno " + (i+1));
                string line;
                line = Console.ReadLine();
                alumno.setNombre(line);
                if(line == "*")
                {
                    exit = true;
                }
                Console.WriteLine("Introdce la edad del alumno " + (i+1));
                
                line = Console.ReadLine();
                alumno.setEdad(int.Parse(line));
                listaAlumnos[i] = alumno;

                totalAlumnos = i;
            }
            

            


            Console.WriteLine("Los Alumnos mayores de edad son los siguientes: ");
            Alumno mayor = new Alumno();
            int numeroMayor = 0;
            for (int i = 0; i < totalAlumnos; i++)
            {
                if(listaAlumnos[i].getEdad() >= 18)
                {
                    listaAlumnos[i].printAlumno(i);
                }

                if(listaAlumnos[i].getEdad() > mayor.getEdad())
                {
                    mayor = listaAlumnos[i];
                    numeroMayor = i;
                }
                
            }

            Console.WriteLine("\nEl Alumno más viejo es: ");
            mayor.printAlumno(numeroMayor);


        }

        
    }
}
