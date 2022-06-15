int greater = int.MinValue;

Console.Write("Quantos números irá digitar? ");
int count = int.Parse(Console.ReadLine());

for (int i = 1; i <= count; i++)
{
    Console.Write($"Digite o {i}º número: ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out var number))
    {
        Console.WriteLine($"Entrada inválida: \"{input}\"");
        i--;
    }
    else
    {
        if(number > greater)
        {
            greater = number;
        }
    }
}

Console.WriteLine($"Maior número digitado: {greater}");
