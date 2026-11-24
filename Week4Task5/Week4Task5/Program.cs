namespace Week4Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the day: ");
        string day = Console.ReadLine();

        DayType type;
        if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }
        Console.WriteLine("It is: " + type);

        Book book1 = new Book("C# Basics", "John", 500);
        Book book2 = book1 with { title = "Advanced C#", price = 800 };

        Console.WriteLine(book1);

        var (title, author, price) = book2;
        Console.WriteLine($"{title}, {author}, {price}");
    }
}