Console.WriteLine("The Potter House Game");

Console.Write("What's your name? ");
string name = Console.ReadLine();

IntroduceYourself(name);
ContButnProced();
Console.ReadLine();

Console.Write("Pick a color: (1) Purple , (2) Yellow, (3) Green, (4) Black: ");
string color = Console.ReadLine();

PickAColor(color,name);
Console.ReadLine();

static void IntroduceYourself(string message)
{
    Console.WriteLine($"Welcome to The Potter House {message}.");
}
static void PickAColor(string myColor, string myName)
{
    if (myColor == "1")
        Console.WriteLine($"Hufflepuff is your house {myName}.");

    else if (myColor == "2")
        Console.WriteLine($"Griffindoor is your house {myName}.");
    else if (myColor == "3")
        Console.WriteLine($"RavenClaw is your house {myName}.");
    else if (myColor == "4")
        Console.WriteLine($"Slitherin is your house {myName}.");
    else
        Console.WriteLine("Invalid Entry. Exiting Program");
}
static void ContButnProced()
{
    Console.WriteLine("Press any key to continue...");
}