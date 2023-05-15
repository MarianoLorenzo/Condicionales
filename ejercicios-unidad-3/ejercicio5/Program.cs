using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Ingrese el 1er número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 2do número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 3er número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el 4to número: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > 100)
                Console.WriteLine(n1 + " es mayor a 100");

            if (n2 > 100)
                Console.WriteLine(n2 + " es mayor a 100");

            if (n3 > 100)
                Console.WriteLine(n3 + " es mayor a 100");

            if (n4 > 100)
                Console.WriteLine(n4 + " es mayor a 100");      

        }
    }
}
