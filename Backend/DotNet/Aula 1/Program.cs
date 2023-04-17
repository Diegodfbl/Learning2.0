// See https://aka.ms/new-console-template for more information
// INSTRUÇÃO DE NÍVEL SUPERIOR. CRU e nada mais. somente 1 arq por projeto assim.
using System.Diagnostics;
using FluentColorConsole;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine($"Você digitou: {nome}");

        var textLine = ColorConsole.WithBlueText;
        textLine.WriteLine("Tchau!");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}