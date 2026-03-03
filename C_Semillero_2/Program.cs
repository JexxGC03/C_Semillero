using System; 
using System.Timers;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        Persona pedro = new Persona();
        pedro.name = "Pedro Picapiedra";
        pedro.bornYear = 2003;

        pedro.Saludar();
    }

}

class Persona
{
    public string name;
    public short bornYear;

    public void Saludar ()
    {
        Console.WriteLine("Hola, soy {0}", name);
    }
}

