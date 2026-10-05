/*
i) Crie um programa que solicite ao usuário o seu nome e verifique se ele é
igual a "Wilson" OU "Gloria". Se o nome for igual a "Wilson" OU "Gloria",
o programa deve imprimir a mensagem "Olá, bem-vindo(a) de volta!".
*/

using System;

class ExercicioI
{
    static void Main()
    {
        // Solicita o nome do usuário
        Console.Write("Digite seu nome: ");

        // Lê e normaliza a entrada
        string nome = Console.ReadLine()?.Trim() ?? string.Empty;

        // Verifica se o nome é Wilson OU Gloria (ignora maiúsculas/minúsculas)
        string nomeNormalizado = nome.ToLowerInvariant();
        if (nomeNormalizado == "wilson" || nomeNormalizado == "gloria")
        {
            Console.WriteLine("Olá, bem-vindo(a) de volta!");
        }
    }
}
