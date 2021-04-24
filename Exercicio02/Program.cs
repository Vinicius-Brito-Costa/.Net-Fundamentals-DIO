using System;
using Instrucoes;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] longString = {"um", "dois", "três", "quatro"};
            /*longString = new string["um", "dois", "três", "quatro"];
            longString = new string[]{"um", "dois", "três", "quatro"};*/
            longString[3] = "cinco";

            Exemplos.Declaracoes();

            Exemplos.InstrucaoIf(new string[]{});
            Exemplos.InstrucaoIf(new string[]{"um"});
            Exemplos.InstrucaoIf(new string[]{"um", "dois"});
            Exemplos.InstrucaoIf(longString);

            Exemplos.InstrucaoSwitch(2);
            Exemplos.InstrucaoSwitch(4);

            Exemplos.InstrucaoWhile(longString);

            Exemplos.InstrucaoDoWhile(longString);

            Exemplos.InstrucaoFor(longString);

            Exemplos.InstrucaoForEach(longString);

            Exemplos.InstrucaoUsing(longString);
        }
    }
}
