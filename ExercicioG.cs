/*
g) Crie um programa que solicite ao usuário um número inteiro e verifique se
ele é divisível por 3 OU por 5. Se o número for divisível por 3 OU por 5, o
programa deve imprimir a mensagem "O número é divisível por 3 ou por 5!".
*/

using System;

class ExercicioG
{
    static void Main()
    {
        // Pede um número inteiro ao usuário
        Console.Write("Digite um número inteiro: ");

        // Lê a entrada e tenta converter para inteiro de forma segura
        string? entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Entrada inválida. Informe um número inteiro.");
            return;
        }

        // Verifica se é divisível por 3 OU por 5
        if (numero % 3 == 0 || numero % 5 == 0)
        {
            Console.WriteLine("O número é divisível por 3 ou por 5!");
        }
    }
}
