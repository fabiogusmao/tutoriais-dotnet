int greater = int.MinValue;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("Digite os números (separados por espaços): ");
var inputs = Console.ReadLine().Split(" ");


foreach (var input in inputs)
{
    if (!int.TryParse(input, out var number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Entrada inválida: \"{input}\"");
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    else
    {
        if (number > greater)
        {
            greater = number;
        }
    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Maior número digitado: {greater}");
Console.ForegroundColor = ConsoleColor.Gray;
