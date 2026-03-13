using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        string[,] alunos = new string[5, 2];
        int cadastrados = 0;
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Mostrar média das notas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (cadastrados >= 5)
                    {
                        Console.WriteLine("Limite de alunos atingido.");
                    }
                    else
                    {
                        Console.Write("Nome do aluno: ");
                        alunos[cadastrados, 0] = Console.ReadLine();

                        Console.Write("Nota do aluno: ");
                        alunos[cadastrados, 1] = Console.ReadLine();

                        cadastrados++;
                        Console.WriteLine("Aluno cadastrado com sucesso.");
                    }
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 2:
                    Console.WriteLine("\n--- Lista de Alunos ---");
                    for (int i = 0; i < cadastrados; i++)
                    {
                        Console.WriteLine($"Aluno: {alunos[i, 0]} - Nota: {alunos[i, 1]}");
                    }
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 3:
                    if (cadastrados == 0)
                    {
                        Console.WriteLine("Nenhum aluno cadastrado.");
                    }
                    else
                    {
                        double soma = 0;

                        for (int i = 0; i < cadastrados; i++)
                        {
                            soma += double.Parse(alunos[i, 1]);
                        }

                        double media = soma / cadastrados;
                        Console.WriteLine($"Média das notas: {media:F2}");
                    }
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

        } while (opcao != 4);
    }
}