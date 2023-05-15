using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float v, importe;

            Console.WriteLine("Ingrese importe de venta: ");
            v = float.Parse(Console.ReadLine());

            if (v < 1000) {
                importe = v;
                Console.WriteLine("El importe final es: $ " + importe);        
            }
            else if (v <= 5000) {
                importe = v * 0.9F; 
                Console.WriteLine("El importe final es: $ " + importe);    
            }
            else {
                importe = v * 0.82F;
                Console.WriteLine("El importe final es: $ " + importe);
            }
                
        }
    }
}
