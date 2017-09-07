using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrupedo Cuadru1 = new Husky();
            Perros Perro1 = new Chihuaha();

            Simios Simio1 = new Gorila();
            Humanos Persona1 = new Europeo();

           // Gorila Gorila = new Gorila();
           //  Gorila.status();

            Console.WriteLine(Cuadru1.Caminar());
            Console.WriteLine(Perro1.Caminar());
            Console.WriteLine(Simio1.Caminar());
            Console.WriteLine(Persona1.Caminar());
            Console.WriteLine();
            Console.WriteLine(Cuadru1.Saltar());
            Console.WriteLine(Perro1.Saltar());
            Console.WriteLine(Simio1.Saltar());
            Console.WriteLine(Persona1.Saltar());

            Console.ReadKey();
        }
    }
}
