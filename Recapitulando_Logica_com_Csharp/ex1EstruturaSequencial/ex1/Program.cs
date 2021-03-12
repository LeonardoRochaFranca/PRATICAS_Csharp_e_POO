using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos.
            System.Console.Write("Digite o valor: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor: ");
            int b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
