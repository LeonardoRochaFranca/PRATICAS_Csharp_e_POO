using System;
using System.Globalization;
namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.            
            System.Console.Write("Digite o número do funcionário: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor recebido por horas trabalhadas: ");
            double valorHora = double.Parse(Console.ReadLine());
            double salario = horasTrabalhadas * valorHora;
            Console.WriteLine($"Number = {number}");
            Console.WriteLine($"SALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
