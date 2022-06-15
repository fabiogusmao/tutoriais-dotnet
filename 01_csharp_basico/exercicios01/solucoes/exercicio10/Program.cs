public class Program
{
    public static void Main()
    {
        var inputs = ReadNumbers();
        if (inputs is null)
            return;
        PrintAverage(inputs);
    }

    private static void PrintAverage(string[] inputs)
    {
        decimal sum = 0m;
        int count = 0;

        foreach (var input in inputs)
        {
            HandleInput(input, ref sum, ref count);
        }
        Print($"A média dos números é: {sum / count}", ConsoleColor.Green);
    }
    private static void HandleInput(string input, ref decimal sum, ref int count)
    {
        if (!int.TryParse(input, out var number))
        {
            Print($"Entrada inválida: \"{input}\"", ConsoleColor.Red);
        }
        else
        {
            sum += number;
            count++;
        }
    }

    private static string[]? ReadNumbers()
    {
        Print("Digite os números (separados por espaços): ", ConsoleColor.Gray);
        string[]? inputs = Console.ReadLine()?.Split(" ");
        return inputs;
    }
    private static void Print(string message, ConsoleColor foregroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.Write(message);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

