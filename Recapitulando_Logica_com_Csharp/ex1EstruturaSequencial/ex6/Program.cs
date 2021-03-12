using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
// Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
// a) a área do triângulo retângulo / b) a área do círculo de raio C. / c) a área do trapézio que tem A e B por bases e C por altura./ d) a área do quadrado que tem lado B. / e) a área do retângulo que tem lados A e B.
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0]);
            double b = double.Parse(vet[1]);
            double c = double.Parse(vet[2]);
            double triangulo = (a*c)/2;
            double circulo = 3.14159 * Math.Pow(c, 2);
            double trapezio = (a+b)*c/2;
            double quadrado = b*b;
            double retangulo = a*b;
           Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3")}");
           Console.WriteLine($"CIRCULO: {circulo.ToString("F3")}");
           Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3")}");
           Console.WriteLine($"QUADRADO: {quadrado.ToString("F3")}");
           Console.WriteLine($"RETANGULO: {retangulo.ToString("F3")}");
        }
    }
}
