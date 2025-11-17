// Task 6: Debugging
Console.WriteLine("TASK 6: Debugging");

// Using TryParse 
Console.Write("Enter marks: ");
string marksInput = Console.ReadLine();
int marks;
bool marksSuccess = int.TryParse(marksInput, out marks);

Console.Write("Enter total: ");
string totalInput = Console.ReadLine();
int total;
bool totalSuccess = int.TryParse(totalInput, out total);

// Calculate percentage 
double percentage = marks / total * 100;

Console.WriteLine($"Percentage: {percentage}%");

// Debugging analysis
Console.WriteLine("\n=== DEBUGGING ANALYSIS ===");
Console.WriteLine("Why is the output incorrect?");
Console.WriteLine("Because integer division truncates decimal places");
Console.WriteLine("marks / total performs integer division before multiplication");
Console.WriteLine("\nHow to correct the program?");
Console.WriteLine("Use casting: (double)marks / total * 100");