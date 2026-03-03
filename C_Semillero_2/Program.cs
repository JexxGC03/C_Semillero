using System; 
using System.Timers;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        //Solicita 4 números, los memoriza en un array y calcula la media
        int[] numbers = new int[4];
        int suma = 0;
        double media = 0;
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Digite el número {0}: ", i+1);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            suma = suma + numbers[i];
        }
        
        media = (double)suma / numbers.Length;
        Console.WriteLine("La media es: " + media);

        //Programa almacena los días de cada mes, el usuario digita un mes (1-12) muestra los días
        int[] daysForMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        byte month;

        Console.WriteLine("Digite el número de un mes para saber sus días: ");
        month = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("El mes {0} tiene {1} días.", month, daysForMonth[month-1]);


        //Progrma solicita una fecha y genera cuantos días faltan para que se acabe el año
        suma = 0;
        Console.WriteLine("Digite el número de un mes: ");
        month = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("Digite el número de un día del mes: ");
        var day = Convert.ToByte(Console.ReadLine());

        for (int i = 11; i >= month-1; i--)
        {
            if (i == month - 1)
                suma = suma + (daysForMonth[i] - day);
            else
                suma = suma + daysForMonth[i];
        }

        Console.WriteLine("Faltan {0} días para que se acabe el año.", suma);
    }

}

