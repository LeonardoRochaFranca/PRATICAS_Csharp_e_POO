using System;
using System.Globalization;
namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o código da peça A: ");
            int codPecaA = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o número de peças A: ");
            int qtdPecaA = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor unitário da peça A: ");
            double valorPecaA = double.Parse(Console.ReadLine());
            double totalPecaA = qtdPecaA * valorPecaA;
            System.Console.WriteLine("-----------------------");
            System.Console.Write("Digite o código da peça B: ");
            int codPecaB = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o número de peças B: ");
            int qtdPecaB = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor unitário da peça B: ");
            double valorPecaB = double.Parse(Console.ReadLine());
            double totalPecaB = qtdPecaB * valorPecaB;
            System.Console.WriteLine("-----------------------");
            double total = totalPecaA + totalPecaB;
            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
