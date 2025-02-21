using System;
using System.Globalization;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Insere um numero inteiro: ");
            
            string str = Console.ReadLine();
            int i = int.Parse(str);
            Console.WriteLine("Insere um numero real: ");

            string str2 = Console.ReadLine();
            float f = float .Parse(str2);


            string x = $"{i} mais {f} e' igual a {i + f}";
            
            Console.WriteLine(x);
        }
    }
}
