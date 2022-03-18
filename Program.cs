using System;

namespace Consolaactividadgit
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("---- Hola Elevaremos a la 2 el numero que ingrese ----");
            Console.WriteLine("Ingrese un numero");
            Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Su numero es: "+ Numero + "  -La elevacion es: " + (Numero * Numero));
        }
    }
}
