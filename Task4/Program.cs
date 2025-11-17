// Task4 : Constructors

// by using default constructor
Player player1 = new Player();
player1.playerName = "Default Player";
player1.level = 3;
player1.health = 130;
player1.DisplayInfo();

//By using parameterized constructor
Player player2 = new Player("Pranisha", 10, 250);
player2.DisplayInfo();