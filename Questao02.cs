using System;
using System.Text;

class Questao02
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        int inicio, fim;

        Console.Write("Digite primeiro número da sequência: ");
        inicio = int.Parse(Console.ReadLine());

        Console.Write("Digite o último número da sequência: ");
        fim = int.Parse(Console.ReadLine());

        if (inicio >= fim)
        {
            Console.WriteLine("Erro: o número inicial deve ser menor que o número final.");
        }
        else
        {
            Console.WriteLine("Números no intervalo:");

            for (int i = inicio; i <= fim; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}