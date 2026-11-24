namespace Week4Task3;

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();

        int num = 5;
        demo.Increase(ref num);
        Console.WriteLine("After Increase: " + num);

        string name;
        demo.GetFullName(out name);
        Console.WriteLine("Full name: " + name);

        Console.WriteLine("Sum: " + demo.SumAll(1, 2, 3, 4, 5));
    }
}