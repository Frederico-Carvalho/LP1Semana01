using System;
using System.Runtime.InteropServices;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string message = "Hello world!";
            message = "\b Alterar os conteudos da string";
            string Symbols = "\t \u03B2";
            string seta = "\n \u003E";

            Console.WriteLine(message);
            Console.WriteLine(Symbols);
            Console.WriteLine(seta);
        }
    }
}
