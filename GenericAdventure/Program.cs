// See https://aka.ms/new-console-template for more information
using GenericAdventure;

Console.WriteLine("Hello, what is your name?");
var name = Console.ReadLine();

if (name == string.Empty)
{
    name = "No Name";
}

var player = new Player(name!);

Console.WriteLine($"Welcome, {player.Name}, to your generic adventure!");