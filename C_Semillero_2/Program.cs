using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        int a, b;

        try
        {

            Console.Write("Digite el primero número para la operación: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el segundo número para la operación: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("La operación (A+B)/(A-B) es: ");
            Console.WriteLine((a + b) / (a - b));
        }
        catch (FormatException)
        {
            Console.Write("Formato de número incorrecto");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Digite números diferentes, la resta de a - b es igual a 0");
        }
        Console.WriteLine("...");
    }
}
