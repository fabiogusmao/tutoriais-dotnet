public class Program
{
    public static void Main()
    {
        var inputs = ReadNumbers();
        if (inputs is null)
            return;
        PrintSum(inputs);
    }

    private static void PrintSum(string[] inputs)
    {
        int sum = 0;

        foreach (var input in inputs)
        {
            sum = HandleInput(input, sum);
        }
        Print($"A soma dos números é: {sum}", ConsoleColor.Green);
    }
    private static int HandleInput(string input, int sum)
    {
        if (!int.TryParse(input, out var number))
        {
            Print($"Entrada inválida: \"{input}\"", ConsoleColor.Red);
        }
        else
        {
            sum += number;
        }
        return sum;
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

