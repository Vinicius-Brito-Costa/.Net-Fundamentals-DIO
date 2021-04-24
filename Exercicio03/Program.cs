using System;
using Heranca;
namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);
            Ponto p2 = new Ponto3D(15, 20, 10);
            Metodos.Ref.Inverter();
            Metodos.Out.Dividir();
        }
    }
}
