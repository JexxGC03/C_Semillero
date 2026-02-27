using System;

//Programa que pide al el usuario una cantidad en metros y lo convierte en millas
//JesusG
class Program
{
    static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese el número para imprimir la tabla de multiplicar: ");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} X 1 = {1}", num, num * 1);
        Console.WriteLine("{0} X 2 = {1}", num, num * 2);
        Console.WriteLine("{0} X 3 = {1}", num, num * 3);
        Console.WriteLine("{0} X 4 = {1}", num, num * 4);
        Console.WriteLine("{0} X 5 = {1}", num, num * 5);
        Console.WriteLine("{0} X 6 = {1}", num, num * 6);
        Console.WriteLine("{0} X 7 = {1}", num, num * 7);
        Console.WriteLine("{0} X 8 = {1}", num, num * 8);
        Console.WriteLine("{0} X 9 = {1}", num, num * 9);
        Console.WriteLine("{0} X 10 = {1}", num, num * 10);
    }
}
