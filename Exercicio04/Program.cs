using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] Alunos = new Aluno[5];
            int indexAlunos = 0;
            int escolhaUsuario = ObterEscolhaUsuario();
            while (escolhaUsuario != 0)
            {
                switch (escolhaUsuario)
                {
                    case 1:
                        Console.Write("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.Write("Informe a nota geral do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.NotaGeral = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        Alunos[indexAlunos] = aluno;
                        indexAlunos++;
                        break;
                    case 2:
                        Console.WriteLine("Lista de alunos cadastrados:");
                        for (int index = 0; index < indexAlunos; index++)
                        {
                            Console.WriteLine($"{index + 1} - Nome: {Alunos[index].Nome} - Nota: {Alunos[index].NotaGeral}");
                        }
                        break;
                    case 3:
                        decimal mediaTurma = 0;
                        for (int index = 0; index < indexAlunos; index++)
                        {
                            mediaTurma += Alunos[index].NotaGeral;
                        }
                        Console.WriteLine($"Média da turma: {mediaTurma / indexAlunos}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                escolhaUsuario = ObterEscolhaUsuario();
            }
            Console.WriteLine("Dippin...");
        }

        private static int ObterEscolhaUsuario()
        {
            Console.WriteLine("~~~~~~~~~~ Menu ~~~~~~~~~~");
            Console.WriteLine("");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine(" 1 - Inserir novo aluno");
            Console.WriteLine(" 2 - Listar alunos");
            Console.WriteLine(" 3 - Calcular média geral");
            Console.WriteLine(" 0 - Sair");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Digite sua escolha: ");
            int escolhaUsuario = Int32.Parse(Console.ReadLine());
            return escolhaUsuario;
        }
    }
}
