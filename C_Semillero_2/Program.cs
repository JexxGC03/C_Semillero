using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        //Juego para adivinar número con intentos maximos
        const int MAX_ATTEMPS = 5;
        const int CORRECT_NUMBER = 17;

        int num, attemps = MAX_ATTEMPS;
        bool foundNumber = false;

        do
        {
            Console.WriteLine("Adivina el número, introduce el numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == CORRECT_NUMBER)
                foundNumber = true;

            attemps--;
        }
        while (!foundNumber && attemps > 0);
    }

}

