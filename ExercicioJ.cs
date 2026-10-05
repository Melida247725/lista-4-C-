/*
j) Escreva um programa que solicite ao usuário um número inteiro e verifique
se ele é maior do que 10 OU menor do que 0. Se o número for maior do que
10 OU menor do que 0, o programa deve imprimir a mensagem "Número inválido!".
*/

using System;

class ExercicioJ
{
    static void Main()
    {
        // Solicita um número inteiro
        Console.Write("Digite um número inteiro: ");

        // Lê e converte com validação
        string? entrada = Console.ReadLine();
        if (!int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Entrada inválida. Informe um número inteiro.");
            return;
        }

        // Verifica se o número é maior que 10 OU menor que 0
        if (numero > 10 || numero < 0)
        {
            Console.WriteLine("Número inválido!");
        }
    }
}
