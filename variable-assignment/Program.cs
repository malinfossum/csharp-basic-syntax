namespace VariableAssignment;

public class Program
{
    public static void Main()
    {
        Task1();
        Console.WriteLine();
        Task2();
        Console.WriteLine();
        Task3();
        Console.WriteLine();
        Task4();
        Console.ReadKey();
    }

    // Task 1:
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

    // Task 2:
    static void Task2()
    {
        int a = 5;
        decimal b = 3;
        var sum = a + b;

        Console.WriteLine("=== Task 2 ===");
        Console.WriteLine($"a (int)     = {a}");
        Console.WriteLine($"b (decimal) = {b}");
        Console.WriteLine($"sum         = {sum}  (type: {sum.GetType().Name})");
    }

    // Task 3:
    static void Task3()
    {
        Console.WriteLine("=== Task 3 ===");
        int result = AddTwoNumbers(5, 7);
        Console.WriteLine($"AddTwoNumbers(5, 7) = {result}");
    }

    static int AddTwoNumbers(int input1, int input2)
    {
        return input1 + input2;
    }

    // Task 4:
    static void Task4()
    {
        Console.WriteLine("=== Task 4 ===");
        PrintNothingMessage();
    }

    static void PrintNothingMessage()
    {
        Console.WriteLine("Denne metoden returnerer ingenting");
    }
}
