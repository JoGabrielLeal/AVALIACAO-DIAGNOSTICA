using System;
using System.Text;

class Questao03
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        int[] numeros = new int[10];
        int maior;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        maior = numeros[0];

        for (int i = 1; i < 10; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.Clear();

        Console.WriteLine($"O maior número digitado foi: {maior}");
    }
}