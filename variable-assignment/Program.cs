namespace VariableAssignment;

public class Program
{
    public static void Main()
    {
        Task1();
        Console.WriteLine();
        Task2();
    }

    // Task 1: 8 variables, one of each type
    static void Task1()
    {
        int integer = 42;
        long longInteger = 9_000_000_000L;
        float floatingPoint = 3.14f;
        decimal decimalNumber = 19.99m;
        double doubleNumber = 2.71828;
        string text = "Hello, C#!";
        char letter = 'M';
        bool truthValue = true;

        Console.WriteLine("=== Task 1 ===");
        Console.WriteLine($"int     : {integer}");
        Console.WriteLine($"long    : {longInteger}");
        Console.WriteLine($"float   : {floatingPoint}");
        Console.WriteLine($"decimal : {decimalNumber}");
        Console.WriteLine($"double  : {doubleNumber}");
        Console.WriteLine($"string  : {text}");
        Console.WriteLine($"char    : {letter}");
        Console.WriteLine($"bool    : {truthValue}");
    }

    // Task 2: a, b, sum — what type must sum be?
    static void Task2()
    {
        int a = 5;
        decimal b = 3;
        var sum = a + b; // int + decimal widens to decimal

        Console.WriteLine("=== Task 2 ===");
        Console.WriteLine($"a (int)     = {a}");
        Console.WriteLine($"b (decimal) = {b}");
        Console.WriteLine($"sum         = {sum}  (type: {sum.GetType().Name})");
    }
}
