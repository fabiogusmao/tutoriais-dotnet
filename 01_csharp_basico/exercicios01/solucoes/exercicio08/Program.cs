public class Program
{
    public static void Main()
    {
        var inputs = ReadNumbers();
        if (inputs is null)
            return;
        PrintEvenOdd(inputs);
    }

    private static void PrintEvenOdd(string[] inputs)
    {
        var even = new List<int>();
        var odd = new List<int>();

        foreach (var input in inputs)
        {
            HandleInput(input, even, odd);
        }
        PrintEvenOdd(even, odd);
    }
    private static void HandleInput(string input, List<int> even, List<int> odd)
    {
        if (!int.TryParse(input, out var number))
        {
            Print($"Entrada inválida: \"{input}\"", ConsoleColor.Red);
        }
        else
        {
            AddEvenOrOdd(number, even, odd);
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
    private static void AddEvenOrOdd(int number, List<int> even, List<int> odd)
    {
        if (number % 2 == 0)
            even.Add(number);
        else
            odd.Add(number);
    }
    private static void PrintEvenOdd(List<int> even, List<int> odd)
    {
        Console.WriteLine("Números pares:");
        PrintList(even);
        Console.WriteLine("Números ímpares:");
        PrintList(odd);
    }
    private static void PrintList(List<int> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            Console.WriteLine($"{i} -> {list[i]}");
        }
    }
}

