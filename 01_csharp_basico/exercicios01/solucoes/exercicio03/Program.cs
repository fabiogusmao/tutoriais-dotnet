
bool quit = false;
int greater = int.MinValue;
do
{
    Console.Write("Digite um número: ");
    var input = Console.ReadLine();
    if (input == "fim")
    {
        quit = true;
    }
    else
    {
        if (!int.TryParse(input, out var number))
        {
            Console.WriteLine($"Valor digitado não é válido: \"{input}\".");
            continue;
        }
        if (number > greater)
            greater = number;

        Console.WriteLine($"Maior número até o momento: {greater}");
    }
} while (!quit);
