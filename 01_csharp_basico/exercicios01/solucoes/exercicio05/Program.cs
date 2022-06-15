int greater = int.MinValue;
Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("Quantos números irá digitar? ");
int count = int.Parse(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    Console.Write($"Digite o {i}º número: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out var number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Entrada inválida: \"{input}\"");
        i--;
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
