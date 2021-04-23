using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Int32.Parse(Console.ReadLine());
            int numeroDeVezes = input;
            for(int i = 0; i < numeroDeVezes; i++){
                Console.WriteLine($"Bem vindo ao curso de .NET {i}");
            }
        }
    }
}
