using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        int a = 0;

        while (a != 1234)
        {
            Console.Write("Digite la contraseña: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a != 1234 ) 
                Console.WriteLine("Contraseña Incorrecta");
        }

        Console.WriteLine("Bienvenido");
    }
}
