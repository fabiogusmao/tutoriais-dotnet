
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
        int number = int.Parse(input);
        if (number > greater)
            greater = number;

        Console.WriteLine($"Maior número até o momento: {greater}");
    }
} while (!quit);
