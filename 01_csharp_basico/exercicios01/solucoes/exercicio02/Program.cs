
string input;
int greater = int.MinValue;
do
{
    Console.Write("Digite um número: ");
    input = Console.ReadLine();
    if(input == "fim")
        break;
    int number = int.Parse(input);
    if (number > greater)
        greater = number;

    Console.WriteLine($"Maior número até o momento: {greater}");
} while (true);
