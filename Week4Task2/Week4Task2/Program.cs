using System;

namespace Week4Task2;

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.PrintWelcome();
        Console.WriteLine("Add: " + calc.Add(5, 3));
        Console.WriteLine("Multiply (both numbers): " + calc.Multiply(5, 3));
        Console.WriteLine("Multiply (default 1): " + calc.Multiply(5));
    }
}