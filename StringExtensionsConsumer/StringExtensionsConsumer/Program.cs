using StringExtensions;

class Program
{
    static void Main(string[] args)
    {
        string test1 = "Hello";
        string test2 = "world";

        Console.WriteLine($"Does '{test1}' start with an uppercase letter? {test1.StartsWithUpperCase()}");
        Console.WriteLine($"Does '{test2}' start with an uppercase letter? {test2.StartsWithUpperCase()}");
    }
}