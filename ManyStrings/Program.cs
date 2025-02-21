using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
            
            int x = 5;
            float y = 1.1f;

            string a = "String " + "chama-se " + "String " + "a" + 2;
            string b = "Outros tipos auto convertidos: " + "abc" + x;
            string c = "Isto: " + x + "" + y;
            c += " Soma Tudo"; 

            string d = $"O valor de {x} e'  {x}";
            string e = $"{x} mais {y} e' igual a {x + y}";

            Console.WriteLine(message);
            Console.WriteLine(Symbols);
            Console.WriteLine(seta);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
