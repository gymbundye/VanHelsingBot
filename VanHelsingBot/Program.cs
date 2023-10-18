
using VanHelsingBot;

Console.WriteLine("I am Van Helsing Bot!");
Console.WriteLine("How may I help you fight the forces of evil?");
Console.WriteLine("Press 1 to add a Monster to the database.");
Console.WriteLine("Type exit to end program.");

var userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1") 
    {
        var monster = new Monster();

        Console.WriteLine("Adding new Monster to the database!");

        Console.WriteLine("What is the name of the fiend?");
        monster.Name = Console.ReadLine();

        Console.WriteLine("Can you describe the Demon?");
        monster.Description = Console.ReadLine();

        Console.WriteLine("How can we destroy it?");
        monster.Weakness= Console.ReadLine();

        Console.WriteLine("Where can we find it?");
        monster.Location = Console.ReadLine();


    }
    Console.WriteLine("I am Van Helsing Bot!");
    Console.WriteLine("How may I help you fight the forces of evil?");
    Console.WriteLine("Press 1 to add a Monster to the database.");
    Console.WriteLine("Type exit to end program.");
    userInput = Console.ReadLine();
}