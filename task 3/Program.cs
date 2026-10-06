using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize variables of different types
        byte byteValue = 200;
        short shortValue = 30000;
        int intValue = 42;
        long longValue = 9876543210L;
        float floatValue = 3.14f;
        double doubleValue = 3.14159265359;
        decimal decimalValue = 19.99m;
        char charValue = 'A';
        bool boolValue = true;

        // Convert int 42 to string
        string intAsString = intValue.ToString();

        // Convert string "3.14" to double
        string piText = "3.14";
        double stringAsDouble = double.Parse(piText, CultureInfo.InvariantCulture);

        // Print all variables with labels, types and values
        Console.WriteLine("byte    : " + byteValue.GetType().Name + " = " + byteValue);
        Console.WriteLine("short   : " + shortValue.GetType().Name + " = " + shortValue);
        Console.WriteLine("int     : " + intValue.GetType().Name + " = " + intValue);
        Console.WriteLine("long    : " + longValue.GetType().Name + " = " + longValue);
        Console.WriteLine("float   : " + floatValue.GetType().Name + " = " + floatValue);
        Console.WriteLine("double  : " + doubleValue.GetType().Name + " = " + doubleValue);
        Console.WriteLine("decimal : " + decimalValue.GetType().Name + " = " + decimalValue);
        Console.WriteLine("char    : " + charValue.GetType().Name + " = " + charValue);
        Console.WriteLine("bool    : " + boolValue.GetType().Name + " = " + boolValue);

        Console.WriteLine();
        Console.WriteLine("int 42 converted to string : " + intAsString.GetType().Name + " = " + intAsString);
        Console.WriteLine("string \"3.14\" to double    : " + stringAsDouble.GetType().Name + " = " + stringAsDouble);
    }
}