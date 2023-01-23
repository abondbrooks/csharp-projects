Console.WriteLine("The Potter House Game");

Console.Write("What's your name? ");
string name = Console.ReadLine();

IntroduceYourself(name);
ContButnProced();
Console.ReadLine();

string[] hogWartsHouses = new[] { "Gryffindor", "Hufflepuff", "Ravenclaw", "Slytherin" };

Console.Write("Pick a color: (1) Blue , (2) Yellow, (3) Green, (4) Black: ");
string color = Console.ReadLine();

PickAColor(color,name,hogWartsHouses);
Console.ReadLine();

static void IntroduceYourself(string message)
{
    Console.WriteLine($"Welcome to The Potter House {message}.");
}
static void PickAColor(string myColor, string myName, string[] myArray)
{
   
    if (myColor == "1")
        Console.WriteLine($"{myArray[2]} is your house {myName}.");
    else if (myColor == "2")
        Console.WriteLine($"{myArray[0]} is your house {myName}.");
    else if (myColor == "3")
        Console.WriteLine($"{myArray[3]} is your house {myName}.");
    else if (myColor == "4")
        Console.WriteLine($"{myArray[1]} is your house {myName}.");
    else
        Console.WriteLine("Invalid Entry. Exiting Program");
}
static void ContButnProced()
{
    Console.WriteLine("Press enter key to continue...");
}

