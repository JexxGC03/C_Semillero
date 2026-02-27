using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        int a, b, c;

        Console.WriteLine("Ingresa los siguientes números para comparar");
        Console.Write("Ingresa el primer número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el tercer número: ");
        c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
            Console.WriteLine("El mayor es {0}", a);
        else if (b > c)
            Console.WriteLine("El mayor es {0}", b);
        else 
            Console.WriteLine("El mayor es {0}", c);
    }
}
