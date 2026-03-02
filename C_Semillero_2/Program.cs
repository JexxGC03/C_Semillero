using System;
using System.Timers;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        //Juego para adivinar número con intentos maximos
        Console.WriteLine("Digite un número: ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ahora digite un operador: ");
        var signo = Console.ReadLine();
        Console.WriteLine("Digite un número: ");
        var b = Convert.ToInt32(Console.ReadLine());
        var resultado = 0;
        var operardorValido = true;

        switch (signo){
            case "+":
                resultado = a + b;
                break;
            case "-":
                resultado = a - b;
                break;
            case "*":
                resultado = a * b;
                break;
            case "/":
                resultado = a / b;
                break;
            default:
                Console.WriteLine("Operador incorrecto.");
                operardorValido = false;
                break;
        }

        if (operardorValido)
            Console.WriteLine("El resultado de su operación es: {0} {1} {2} = {3}", a, signo, b, resultado);
        else
            Console.WriteLine("...");
    }

}

