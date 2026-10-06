class Program
{
    static void Main(string[] args)
    {
        // 1. Create an integer array with 5 favorite numbers
        int[] numbers = { 7, 3, 21, 14, 9 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        // 2. Sort the array in ascending order (smallest to largest)
        Array.Sort(numbers);
        Console.WriteLine("After Array.Sort():");
        PrintArray(numbers);

        // 3. Reverse the sorted array (now largest to smallest)
        Array.Reverse(numbers);
        Console.WriteLine("After Array.Reverse():");
        PrintArray(numbers);

        // 4. Find the position (index) of a specific number
        int numberToFind = 9;
        int position = Array.IndexOf(numbers, numberToFind);

        if (position == -1)
        {
            Console.WriteLine("Number " + numberToFind + " was not found in the array.");
        }
        else
        {
            Console.WriteLine("Number " + numberToFind + " is at index " + position + ".");
        }
    }

    // Prints each element of an array using a for loop
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Element " + i + ": " + array[i]);
        }
        Console.WriteLine();
    }
}