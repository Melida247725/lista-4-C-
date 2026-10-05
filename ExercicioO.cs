/*
o) Escreva um programa que pergunte ao usuário se ele não deseja cancelar
uma operação. Se a resposta for negativa, o programa deve imprimir "Por
favor, confirme o cancelamento da operação".
*/

using System;

class ExercicioO
{
    static void Main()
    {
        // Pergunta ao usuário se ele não deseja cancelar a operação
        Console.Write("Você não deseja cancelar a operação? ");

        // Lê a resposta de forma segura e normaliza
        string resposta = Console.ReadLine()?.Trim().ToLowerInvariant() ?? string.Empty;

        // Aceita "não" com e sem acento
        if (resposta == "não" || resposta == "nao")
        {
            Console.WriteLine("Por favor, confirme o cancelamento da operação");
        }
    }
}
