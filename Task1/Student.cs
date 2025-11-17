public class Student
{
    public string name = string.Empty;
    public int age;
    public string course = string.Empty;
    public static string school = "IIC College";

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Course: {course}, School: {school}");
    }
}