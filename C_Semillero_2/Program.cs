using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        // Número del 1 al 20, saltando el 10
        for (int i = 0; i <= 20; i++) 
        { 
            if (i == 10)
                continue;
            Console.WriteLine(i);
        }

        // Número del 1 al 20, saltando el 10
        for (int i = 0; i <= 20; i++)
        {
            if (i == 10)
                break;
            Console.WriteLine(i);
        }
    }
}
