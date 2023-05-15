using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingrese número: ");
            n = int.Parse(Console.ReadLine());

            if (n > 10) 
                Console.WriteLine("Es mayor a 10");
             else
                Console.WriteLine("Es menor a 10");
            

        }
    }
}
