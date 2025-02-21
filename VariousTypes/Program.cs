using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            short a = 3;
            int b = 15;
            long c = 100000L;

            char letra = 'A';
            char matematica = '\u00B1';
            char simbolo = '\u00A9';

            double d = 3.1415;
            decimal e = 3.1415m;
            float f = 3.1415f; 

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(letra);
            Console.WriteLine(matematica);
            Console.WriteLine(simbolo);
            
        }
    }
}
