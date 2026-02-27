using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        // Número del 1 al 200 que también son multiplos de 3 y 7
        for (int i = 1; i <= 200; i++) 
        {
            int m3 = i % 3;
            int m7 = i % 7;

            if (m3 == 0)
                Console.WriteLine("Multiplo de 3: {0}", i);

            if (m7 == 0)
                Console.WriteLine("Multiplo de 7: {0}", i);
        }


        // Pide número hasta que escriba 0
        int num;
        do
        {
            Console.Write("Escribe cualquier número: ");
            num = Convert.ToInt32(Console.ReadLine());
        }
        while (num != 0);

        //Muestra divisores de un número ingresado
        Console.Write("Escribe un número para imprimir sus divisores: ");
        num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1;  i <= num; i++)
        {
            if ((num % i) == 0)
                Console.WriteLine("{0} es divisor de {1}", i, num); 
        }

        //Pregunta un número y dice si es primo
        Console.Write("Introduce un número para verificar si es primo: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            bool esPrimo = true;
            if (numero < 2)
                esPrimo = false;
            else if (numero == 2)
                esPrimo = true;
            else if (numero % 2 == 0)
                esPrimo = false; 
            else
            {
                double limite = Math.Sqrt(numero);
                for (int i = 3; i <= limite; i += 2)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break; 
                    }
                }
            }

            // Resultado final
            if (esPrimo)
                Console.WriteLine($"El número {numero} ES primo.");
            else
                Console.WriteLine($"El número {numero} NO es primo.");
        }
        else
        {
            Console.WriteLine("Por favor, introduce un número entero válido.");
        }

        //5 Oportunidades para advinar contraseña
        int op = 5;
        do
        {
            Console.WriteLine("Intente adivinar la contraseña: ");
            String password;
            password = Console.ReadLine();

            if (password != "12345")
            { 
                op--;
                Console.WriteLine("Incorrecto, tiene {0} oportunidades más.", op);
            }
            else
            {
                op = 0;
                Console.WriteLine("Adivino la Contraseña");
            }


        } while (op >= 1);
    }
}
