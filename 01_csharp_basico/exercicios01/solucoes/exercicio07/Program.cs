public class Program
{
    public static void Main()
    {
        var inputs = ReadNumbers();
        if (inputs is null)
            return;
        PrintGreaterNumber(inputs);
    }

    private static void PrintGreaterNumber(string[] inputs)
    {
        int greater = int.MinValue;
        foreach (var input in inputs)
        {
            greater = HandleInput(input, greater);
        }
        Print($"Maior número digitado: {greater}", ConsoleColor.Green);
    }
    private static int HandleInput(string input, int greater)
    {
        if (!int.TryParse(input, out var number))
        {
            Print($"Entrada inválida: \"{input}\"", ConsoleColor.Red);
            return greater;
        }
        else
        {
            return FindGreater(greater, number);
        }
    }

    private static string[]? ReadNumbers()
    {
        Print("Digite os números (separados por espaços): ", ConsoleColor.Gray);
        string? text = Console.ReadLine();
        if (text is null)
            return null;
        var inputs = text.Split(" ");
        return inputs;
    }
    private static void Print(string message, ConsoleColor foregroundColor)
    {
        Console.ForegroundColor = foregroundColor;
        Console.Write(message);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    private static int FindGreater(int greater, int number)
    {
        return number > greater ? number : greater;
    }    
}

