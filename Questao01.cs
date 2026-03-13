using System;
using System.Text;
class Questao01
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        int opcao = 0;

        while (opcao != 5)
        {
            Console.Clear();
            Console.WriteLine("======= MENU PRiNCIPAL =======");
            Console.WriteLine("1 - Somar dois números");
            Console.WriteLine("2 - Subtrair dois números");
            Console.WriteLine("3 - Multiplicar dois números");
            Console.WriteLine("4 - Dividir dois números");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao >= 1 && opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado: " + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("Resultado: " + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine("Resultado: " + (num1 * num2));
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            Console.WriteLine("Resultado: " + (num1 / num2));
                        }
                        else
                        {
                            Console.WriteLine("Erro: não pode divisão por zero!");
                        }
                        break;
                }
                        Console.WriteLine("\nPressione ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
            }
            else if (opcao != 5)
            {
                Console.WriteLine("Opção inválida!");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Programa encerrado.");
    }
}
