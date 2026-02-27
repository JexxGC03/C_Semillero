using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Console.WriteLine("Ingresa dos númeror para comparar");
        Console.Write("Ingresa el primer número: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa el segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());

        if (a >= b)
            Console.WriteLine("El mayor es {0}", a);
        else
            Console.WriteLine("El mayor es {0}", b);
    }
}
