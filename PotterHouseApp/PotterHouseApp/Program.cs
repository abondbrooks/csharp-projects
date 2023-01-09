Console.WriteLine("The Potter House Game");

Console.Write("What's your name? ");
string name = Console.ReadLine();

IntroduceYourself(name);
Console.ReadLine();

static void IntroduceYourself(string message)
{
    Console.WriteLine($"Welcome to The Potter House {message}.");
}

Console.Write("Pick a color: (1) Purple , (2) Yellow, (3) Green, (4) Black: ");
int color = Console.ReadLine();


static void PickAColor(string myColor)
{
    if (myColor == "1 ")
}