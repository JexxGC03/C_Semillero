using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        int a;
        Console.Write("Ingresa un número de la semana: ");
        a = Convert.ToInt32(Console.ReadLine());

        switch (a) {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("No existe un número de la semana con ese valor");
                break;
        }

        
    }
}
