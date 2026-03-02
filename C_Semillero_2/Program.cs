using System; 
using System.Timers;

//JesusG
class Program
{
    static void Main(string[] args)
    {
        //Digita una cadena y la encripta con XOR
        string text;
        Console.WriteLine("Digite una frase: ");
        text = Console.ReadLine();
        Console.WriteLine("Su texti encriptado es: ");
        
        foreach(char l in text) 
        {
            char encry = (char)(l ^ 3);
            Console.Write(encry);
            char desencry = (char)(encry ^ 3);
            Console.Write (desencry);
            Console.WriteLine();
        }
                   
    }

}

