class Program
{
    static void Main(string[] args)
    {
        // ----- Part 1: List<string> -----

        // 1. Create a list with 3 favorite fruits
        List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

        // 2. Add a new fruit to the list
        fruits.Add("Orange");

        // 3. Remove one fruit from the list
        fruits.Remove("Apple");

        // 4. Print all fruits using a foreach loop
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine("- " + fruit);
        }

        Console.WriteLine();

        // ----- Part 2: Dictionary<int, string> -----

        // 5. Create a dictionary where the key is the fruit ID and the value is the fruit name
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Banana" }
        };

        // 6. Add a new entry
        fruitDictionary.Add(4, "Orange");

        // 7. Print all key-value pairs
        Console.WriteLine("Fruits in the dictionary:");
        foreach (KeyValuePair<int, string> pair in fruitDictionary)
        {
            Console.WriteLine("ID " + pair.Key + " = " + pair.Value);
        }
    }
}