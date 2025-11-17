public enum DayType
{
    Weekday,
    Weekend
}

public record Book(string Title, string Author, double Price);

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 5: Enums and Records");

        // Task 2: Ask user for day input and determine DayType
        Console.Write("Enter day: ");
        string? dayInput = Console.ReadLine();

        // Handle null or empty input with default value
        if (string.IsNullOrWhiteSpace(dayInput))
        {
            Console.WriteLine("No input provided. Using default: Weekday");
            dayInput = "Monday";
        }

        // Trim and convert to lowercase for case-insensitive comparison
        string lowerDay = dayInput.Trim().ToLower();

        // Check if it's Friday or Saturday (weekend)
        DayType dayType = (lowerDay == "friday" || lowerDay == "saturday")
            ? DayType.Weekend
            : DayType.Weekday;

        Console.WriteLine($"It is: {dayType}");
        Console.WriteLine();

        // Task 3 & 4: Book record operations
        // Create first book object
        Book book1 = new Book("C# Programming", "Kushal Tamang", 29.99);

        // Create second book using with expression to modify title and price
        Book book2 = book1 with
        {
            Title = "Advanced C#",
            Price = 49.99
        };

        // Print the first book object
        Console.WriteLine("First Book:");
        Console.WriteLine($"Book1: {book1}");
        Console.WriteLine();

        // Deconstruct the second book and print individual values
        Console.WriteLine("Second Book (deconstructed):");
        var (title, author, price) = book2;
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: ${price:F2}");
    }
}
