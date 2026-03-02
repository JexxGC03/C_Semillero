using System;

//JesusG
class Program
{
    static void Main(string[] args)
    {

        //Pide los 2 catetos de un tringulo rectangulo y le devuelve la hipotenusa
        double a, b, hipot;
        Console.WriteLine("Digite el valor del primer cateto: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite el valor del segundo cateto: ");
        b = Convert.ToInt32(Console.ReadLine());
        hipot = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
        Console.WriteLine("La hipotenusa del tringulo es {0}", hipot);


        //Pide un número y devuelve raiz cubica, elevado a la 1/3
        double num;
        Console.WriteLine("Digite un número: ");
        num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("La raíz cubica es  {0}", Math.Pow(num, 1/3));

        //Pide un angulo y devuelve el Seno, Coseno y Tangente
        Console.Write("Introduce un ángulo en grados: ");
        double grados = Convert.ToDouble(Console.ReadLine());

        double radianes = grados * (Math.PI / 180.0);
        double seno = Math.Sin(radianes);
        double coseno = Math.Cos(radianes);
        double tangente = Math.Tan(radianes);

        Console.WriteLine("Para un angulo de {0} el Coseno es {1}, Seno {2}, Tangente {3}",
            grados, coseno, seno, tangente);

    }
}
