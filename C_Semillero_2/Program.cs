using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {

        //Mini traductor de C# a Java
        Console.WriteLine("Introduce una instrucción de C# (if, while, for, Console.WriteLine):");
        Console.Write("> ");

        string entrada = Console.ReadLine().Trim();

        switch (entrada)
        {
            case "if":
                Console.WriteLine("Equivalencia en Java: if (condición) { ... }");
                break;

            case "while":
                Console.WriteLine("Equivalencia en Java: while (condición) { ... }");
                break;

            case "for":
                Console.WriteLine("Equivalencia en Java: for (int i=0; i<n; i++) { ... }");
                break;

            case "Console.WriteLine":
                Console.WriteLine("Equivalencia en Java: System.out.println();");
                break;

            default:
                Console.WriteLine(" Error: Orden no reconocida o no soportada actualmente.");
                break;
        }

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }

}

