// Task 2: Methods & Return Types
Calculator calc = new Calculator();
calc.PrintWelcome();

// Call Add method
int sum = calc.Add(5, 3);
Console.WriteLine($"Addition: {sum}");

// Call Multiply with both parameters
int product1 = calc.Multiply(4, 5);
// Call Multiply with default parameter
int product2 = calc.Multiply(7);
Console.WriteLine($"Multiplication 1: {product1}");
Console.WriteLine($"Multiplication 2: {product2}");