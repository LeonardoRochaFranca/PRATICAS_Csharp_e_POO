using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
//Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelomenos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
            string [] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);
            while( x!= 0 || x!=0){
                if( x > 0 && y > 0){
                    System.Console.WriteLine("primeiro");
                }else if(x < 0 && y > 0){
                    System.Console.WriteLine("segundo");
                }else if( x < 0 && y < 0){
                    System.Console.WriteLine("terceiro");
                }else{
                    System.Console.WriteLine("quarto");
                }
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }
            
        }
    }
}
