using System;

//Programa que pide al el usuario una cantidad en metros y lo convierte en millas
//JesusG
class Program
{
    static void Main(string[] args)
    {
        int m;

        Console.Write("Ingrese la cantidad de metros: ");
        m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(m + " metros en millas es : " + (m / 1609.34)); 

    }
}
