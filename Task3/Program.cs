// Task 3: Parameter Types
ParameterDemo paramDemo = new ParameterDemo();

// By using ref parameter
int number = 5;
paramDemo.Increase(ref number);
Console.WriteLine($"After ref: {number};");

// By using out Parameter
paramDemo.GetFullName(out string fullName);
Console.WriteLine($"Out Parameter:{fullName}");

//By using params parameter
int totalsum = paramDemo.SumAll(1, 2, 3);
Console.WriteLine($"Total Sum:{totalsum}");