using System;
using System.Globalization;
namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o valor do Raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
