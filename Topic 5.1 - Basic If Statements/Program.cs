// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

int people = 30;
int cats = 30;
int dogs = 15;
Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
if (people < cats)
{
    Console.WriteLine("Too many cats! The world is doomed!");
}
if (people > cats)
{
    Console.WriteLine("Not many cats! The world is saved!");
}
if (people < dogs)
{
    Console.WriteLine("The world is drooled on!");
}
if (people > dogs)
{
    Console.WriteLine("The world is dry!");
}
Console.WriteLine("Press ENTER to continue. ");
Console.ReadLine();
Console.Clear();
dogs += 5; // Add 5 to dogs. What does dogs equal now?
Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
if (people >= dogs)
{
    Console.WriteLine("People are greater than or equal to dogs.");
}
if (people <= dogs)
{
    Console.WriteLine("People are less than or equal to dogs.");
}
if (people == dogs)
{
    Console.WriteLine("People are dogs.");
}
Console.WriteLine();
string dinosaur;
Console.WriteLine("What famous dinosaur has three large horns?");
dinosaur = Console.ReadLine();
if (dinosaur.ToLower() == "triceratops")
    Console.WriteLine("You are correct.");

string magicWord;
Console.Write("Please say the magic word: ");
magicWord = Console.ReadLine();
if (magicWord.ToLower() == "please")
    Console.WriteLine("You're welcome.");

string name;
int age;
Console.Write("Hey, what's your name? ");
name = Console.ReadLine();
Console.WriteLine();
Console.Write("Ok, " + name + ", how old are you?  ");
int.TryParse(Console.ReadLine(), out age);
Console.WriteLine();

if (age < 16)
{
    Console.WriteLine("You can't drive.");
}
if (age < 18)
{
    Console.WriteLine("You can't vote.");
}
if (age < 25)
{
    Console.WriteLine("You can't rent a car.");
}
if (age >= 25)
{
    Console.WriteLine("You can do anything that is legal.");
}

int temperature;
Console.WriteLine("Please enter the freezing temperature of water: ");
int.TryParse(Console.ReadLine(), out temperature);
if (temperature == 0)
{
    Console.WriteLine("Ahh yes, 0 degrees Celsius is correct.");
}
if (temperature == 32)
{
    Console.WriteLine("Ahh yes, 32 degrees Fahrenheit is correct.");
}
if (temperature == 273)
{
    Console.WriteLine("Ahh yes, 273.2 degrees Kelvin to be precise is correct.");
}