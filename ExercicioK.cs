/*
k) Escreva um programa que pergunte ao usuário se ele não é um robô. Se a
resposta for negativa, o programa deve imprimir "Por favor, prove que você
não é um robô".
*/

using System;

class ExercicioK
{
    static void Main()
    {
        // Pergunta ao usuário se ele não é um robô
        Console.Write("Você não é um robô? ");

        // Lê a resposta de forma segura e normaliza
        string resposta = Console.ReadLine()?.Trim().ToLowerInvariant() ?? string.Empty;

        // Aceita "não" com e sem acento
        if (resposta == "não" || resposta == "nao")
        {
            Console.WriteLine("Por favor, prove que você não é um robô");
        }
    }
}
