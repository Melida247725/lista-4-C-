using System;

class ExercicioF
{
    static void Main()
    {
        Console.Write("Deseja adicionar açúcar ou leite ao café? ");
        string resposta = Console.ReadLine()?.Trim().ToLowerInvariant() ?? string.Empty;

        // Aceita variações com e sem acento
        if (resposta == "açúcar" || resposta == "acucar" || resposta == "leite")
        {
            Console.WriteLine("Café com adicional preparado!");
        }
    }
}
