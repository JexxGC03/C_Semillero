using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        int a, b, cantidadDePsitivos;
        Console.Write("Ingresa un número cualquiera: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa un segundo número: ");
        b = Convert.ToInt32(Console.ReadLine());

        cantidadDePsitivos = (a >= 0 && b >= 0) ? 2 : ((a < 0 && b < 0) ? 0 : 1);
        Console.WriteLine("La catidad de positivos escritos es: {0}", cantidadDePsitivos);


    }
}
