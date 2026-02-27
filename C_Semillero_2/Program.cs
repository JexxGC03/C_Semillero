using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        int a = 0;

        do
        {
            Console.Write("Digite la contraseña: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a != 1234)
                Console.WriteLine("Contraseña Incorrecta");
        }
        while (a != 1234);

        Console.WriteLine("Bienvenido");
    }
}
