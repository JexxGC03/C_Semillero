using System;

namespace C_Semillero_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Ingrese el primer número:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de división entera es: " + (a / b));
            Console.WriteLine(" y su residuo es: " + (a % b));  

        }
    }
}
