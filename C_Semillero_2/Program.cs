using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        // Número de 1 a 20
        for (int i = 0; i <= 20; i++)
            Console.WriteLine(i);

        //Número pares entre 2 y 16
        for (int i = 2; i <=16; i = i+ 2)
            Console.WriteLine(i);

        //Número impares entre 15 y 5, descendido
        for (int i = 15; i >= 5; i = i - 2)
            Console.WriteLine(i);

    }
}
