/*
l) Crie um programa que peça ao usuário para digitar um número e verifique se
ele não é igual a zero. Se a condição for verdadeira, o programa deve
imprimir "O número é diferente de zero".
*/

using System;

class ExercicioL
{
    static void Main()
    {
        // Pede para o usuário digitar um número
        Console.Write("Digite um número: ");

        // Lê a entrada e tenta converter para inteiro
        string? entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Entrada inválida. Informe um número.");
            return;
        }

        // Verifica se o número é diferente de zero
        if (numero != 0)
        {
            Console.WriteLine("O número é diferente de zero");
        }
    }
}
