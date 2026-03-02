using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        ushort year;
        byte age;
        uint poblation;

        Console.Write("Digite su año de nacimiento: ");
        year = Convert.ToUInt16(Console.ReadLine());
        Console.Write("Digite su edad: ");
        age = Convert.ToByte(Console.ReadLine());
        Console.Write("Digite cuantos habitantes tiene su pueblo: ");
        poblation = Convert.ToUInt32(Console.ReadLine());

        Console.WriteLine("Su año de nacimiento es {0}, su edad es {1} y su pueblo tiene {2} cantidad de habitantes",
            year, age, poblation);

    }
}
