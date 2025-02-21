using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            Console.WriteLine("Insere 4 números reais entre 0 e 1: ");
            
            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string str4 = Console.ReadLine();

            float f = float .Parse(str );
            float f2 = float .Parse(str2 );
            float f3 = float .Parse(str3 );
            float f4 = float .Parse(str4 );

            string x1 = $"{f:p1}";
            string x2 = $"{f2:p1}";
            string x3 = $"{f3:p1}";
            string x4 = $"{f4:p1}";

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }
    }
}
