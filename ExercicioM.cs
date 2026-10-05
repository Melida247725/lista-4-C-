/*
m) Escreva um programa que pergunte ao usuário se ele não é um membro
inativo de um clube. Se a resposta for negativa, o programa deve imprimir
"Por favor, atualize sua inscrição para continuar usufruindo dos benefícios
do clube".
*/

using System;

class ExercicioM
{
    static void Main()
    {
        // Pergunta ao usuário se ele não é um membro inativo
        Console.Write("Você não é um membro inativo do clube? ");

        // Lê a resposta de forma segura e normaliza
        string resposta = Console.ReadLine()?.Trim().ToLowerInvariant() ?? string.Empty;

        // Aceita "não" com e sem acento
        if (resposta == "não" || resposta == "nao")
        {
            Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube");
        }
    }
}
