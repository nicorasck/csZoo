using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using Seido.Utilities.SeedGenerator;
namespace GU1_Zoo;

class Program
{
    static void Main(string[] args)
    {
        var rnd = new csSeedGenerator();
        var a1 = new csAnimal(){Name = "Ashok", Mood = enAnimalMood.Happy, Kind = enAnimalKind.Aligator};
        var a2 = new csAnimal(a1); // this copy a1 from the Heap bc class is a ref.type -> HEAP!
        var a3 = new csAnimal(enAnimalKind.Eagle, enAnimalMood.Lazy, rnd.Next(1, 100), rnd.PetName);

        System.Console.WriteLine(a1);
        System.Console.WriteLine(a2);
        System.Console.WriteLine(a3);

        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("\nSmall Zoo");
        Console.ForegroundColor = ConsoleColor.White;
        var z1 = new csZoo(rnd, 5);
        System.Console.WriteLine(z1);

        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("\nLarge Zoo");
        Console.ForegroundColor = ConsoleColor.White;
        var z2 = new csZoo(rnd,25);
        System.Console.WriteLine(z2);

        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("\nEvery animal with their different moods");
        Console.ForegroundColor = ConsoleColor.White;

        var z3 = new csZoo(); // bc of the empty constructor 
        // System.Console.WriteLine(z3);



    }
}

