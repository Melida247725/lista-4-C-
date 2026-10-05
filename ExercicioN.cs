/*
n) Crie um programa que peça ao usuário para digitar uma palavra e verifique
se ela não é vazia. Se a condição for verdadeira, o programa deve imprimir
"A palavra não é vazia".
*/

using System;

class ExercicioN
{
    static void Main()
    {
        // Pede para o usuário digitar uma palavra
        Console.Write("Digite uma palavra: ");

        // Lê a palavra (aceita nulls de forma segura)
        string? palavra = Console.ReadLine();

        // Verifica se a palavra NÃO é nula ou vazia
        if (!string.IsNullOrEmpty(palavra))
        {
            Console.WriteLine("A palavra não é vazia");
        }
    }
}
