public class Calculator
{
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the calculator!");
    }

    // Method with reyurn type
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Multiply(int number1, int number2 = 1)
    {
        return number1 * number2;
    }
}
