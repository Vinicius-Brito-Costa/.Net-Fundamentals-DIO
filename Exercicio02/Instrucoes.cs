using System;
namespace Instrucoes
{
    public class Exemplos
    {
        public static void Declaracoes()
        {
            int a, b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }
        public static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("If: Nenhum argumento meu chapa.");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("If: Um argumento!");
            }
            else
            {
                Console.WriteLine($"If: {args.Length} argumentos!");
            }
        }
        public static void InstrucaoSwitch(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Switch: Opção {opcao}");
                    break;
                case 2:
                    Console.WriteLine($"Switch: Opção {opcao}");
                    break;
                case 3:
                    Console.WriteLine($"Switch: Opção {opcao}");
                    break;
                default:
                    Console.WriteLine($"Switch: A opção {opcao} não é valida!");
                    break;
            }
        }
        public static void InstrucaoWhile(string[] args)
        {
            int index = 0;
            while (index < args.Length)
            {
                Console.WriteLine("While: " + args[index]);
                index++;
            }
        }
        public static void InstrucaoDoWhile(string[] args)
        {
            int index = 0;
            do
            {
                Console.WriteLine("DoWhile: " + args[index]);
                index++;
            }
            while (index < args.Length);
        }
        public static void InstrucaoFor(string[] args)
        {
            for (int index = 0; index < args.Length; index++)
            {
                Console.WriteLine("For: " + args[index]);
            }
        }
        public static void InstrucaoForEach(string[] args){
            foreach(string texto in args){
                Console.WriteLine($"Foreach: {texto}");
            }
        }
        public static void InstrucaoBreak(string[] args){
            while(true){
                string texto = Console.ReadLine();
                if(string.IsNullOrEmpty(texto)){
                    break;
                }
                Console.WriteLine($"Break: {texto}");
            }
        }
        public static void InstrucaoContinue(string[] args){
            for(int index = 0; index < args.Length; index++){
                if(args[index].StartsWith("/"))
                    continue;
                Console.WriteLine(args[index]);
            }
        }
        public static void InstrucaoReturn(string[] args){
            int Somar(int a, int b){
                return a + b;
            }
            if(args.Length == 0)
                return;
            Console.WriteLine(Somar(5, 5));
            Console.WriteLine(Somar(2, 4));
            Console.WriteLine(Somar(10, 1));
            return;
        }
        public static void InstrucaoTryCatchFinallyThrow(double[] args){
            double Dividir(double x, double y){
                if(y == 0)
                    throw new DivideByZeroException();
                return x / y;
            }
            try{
                if(args.Length != 2){
                    throw new InvalidOperationException("Informe 2 números!");
                }
                double x = args[0];
                double y = args[1];
                Console.WriteLine(Dividir(x, y));
            }
            catch(InvalidOperationException e){
                Console.WriteLine(e.Message);
            }
            catch(Exception e){
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally{
                Console.WriteLine("Até breve parça!");
            }
        }
         public static void InstrucaoUsing(string[] args){
             System.IO.TextWriter writer;
             writer = System.IO.File.CreateText("teste.txt");
             for(int index = 0; index < args.Length; index++)
                writer.WriteLine($"Using: {args[index]}");
            writer.Dispose();
         }
    }
}