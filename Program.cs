using System;

namespace CelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {








            double C;
            double F;
            string X;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Conversor Celsius para Fahrenheit");
            Console.ResetColor();
            Console.WriteLine("--- Digite um valor em Celsius a ser convertido para Fahrenheit.");
            Console.WriteLine();

            X = Console.ReadLine();
            Console.WriteLine();

            C = Convert.ToDouble(X);
            F = C * 1.8 + 32;

            Console.WriteLine($"Conversão: {F:N2} °F.");













        }
    }
}
