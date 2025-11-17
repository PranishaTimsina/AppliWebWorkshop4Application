public class Player
{
    // initializw with empty string
    public string playerName = string.Empty;
    public int level;
    public int health;

    // Default Constructor  
    public Player()
    {
        Console.WriteLine("Default constructor has been called");

    }

    // Parameterized constructor
    public Player(string playerName, int level, int health)
    {
        this.playerName = playerName;
        this.level = level;
        this.health = health;

    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name:{playerName}");
        Console.WriteLine($"Level:{level}");
        Console.WriteLine($"Health:{health}");
    }
}