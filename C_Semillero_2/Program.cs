using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {

        //Saca la superficie de un circulo con 2 decimales
        double pi = 3.141596;
        double radio, superficie;

        Console.Write("Digite el radio de un circulo para calcular la superficie: ");
        radio = Convert.ToDouble(Console.ReadLine());
        superficie = (pi * (radio*radio));
        Console.WriteLine("La suoerficie de un circulo con radio {0} es: {1}",
            radio, superficie.ToString("0.00"));


        //Pide un número y lo convierte a Hexa y Binario
        int num;
        do
        {
            int a, b;
            Console.Write("Digita un número: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tu número en hexadecimal es: {0} y en binario es: {1} ",
                Convert.ToString(num, 16),
                Convert.ToString(num, 2));
        }
        while (num != 0);


    }
}
