class Program
{
    static void Main(string[] args)
    {
        // 1. Birthdate (change this to your real birthdate: year, month, day)
        DateTime birthDate = new DateTime(2003, 5, 15);

        // 2. Current date and time (taken from your computer's clock)
        DateTime currentDate = DateTime.Now;

        // 3. Subtracting two DateTime values gives a TimeSpan
        TimeSpan ageSpan = currentDate - birthDate;

        // A TimeSpan counts days, so divide by 365.25 to get years
        // (the .25 accounts for leap years)
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        // 4. Print birthdate, current date, and age
        Console.WriteLine("Birthdate    : " + birthDate.ToString("dd MMMM yyyy"));
        Console.WriteLine("Current date : " + currentDate.ToString("dd MMMM yyyy, HH:mm"));
        Console.WriteLine("Days lived   : " + (int)ageSpan.TotalDays);
        Console.WriteLine("Age in years : " + ageInYears);

        // 5. Add 10 days to the birthdate and print the new date
        DateTime birthDatePlus10 = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days : " + birthDatePlus10.ToString("dd MMMM yyyy"));
    }
}