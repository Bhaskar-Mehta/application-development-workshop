using System;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Name = "Bhaskar";
        s1.Age = 20;
        s1.Course = "Computing";

        Student s2 = new Student();
        s2.Name = "Ram";
        s2.Age = 21;
        s2.Course = "Networking";

        Console.WriteLine($"{s1.Name}, {s1.Age}, {s1.Course}");
        Console.WriteLine($"{s2.Name}, {s2.Age}, {s2.Course}");
        Console.WriteLine($"College: {Student.College}");
    }
}