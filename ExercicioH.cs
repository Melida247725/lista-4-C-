/*
h) Escreva um programa que pergunte ao usuário se ele deseja comprar um
produto. Se o usuário responder "sim" OU "s", o programa deve imprimir a
mensagem "Obrigado pela compra!".
*/

using System;

class ExercicioH
{
    static void Main()
    {
        // Pergunta ao usuário se ele deseja comprar o produto
        Console.Write("Deseja comprar o produto? ");

        // Lê a resposta, trata nulos e normaliza
        string resposta = Console.ReadLine()?.Trim().ToLowerInvariant() ?? string.Empty;

        // Verifica se a resposta é "sim" OU "s"
        if (resposta == "sim" || resposta == "s")
        {
            Console.WriteLine("Obrigado pela compra!");
        }
    }
}
