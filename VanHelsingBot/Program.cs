using VanHelsingBot;
using System.Text.Json.Serialization;
using System.Text.Json;

var monsterLogic = new MonsterLogic();

Console.WriteLine("I am Van Helsing Bot!");
Console.WriteLine("How may I help you fight the forces of evil?");
Console.WriteLine("Press 1 to add a Monster to the database.");
Console.WriteLine("Press 2 to view a Monster in the database.");
Console.WriteLine("Press 3 to see all Monsters in the database.");
Console.WriteLine("Type exit to end program.");

string userInput = Console.ReadLine();

while (userInput?.ToLower() != "exit")
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

        Console.WriteLine("Where does it haunt?");
        monster.Location = Console.ReadLine();

        monsterLogic.AddMonster(monster);

        Console.WriteLine("Monster Added!");


    }
    if (userInput == "2") 
    {  
   
        
            Console.WriteLine("Which Monster do we hunt?");
            var monsterName = Console.ReadLine();
            var monster = monsterLogic.GetMonster(monsterName);
            Console.WriteLine(JsonSerializer.Serialize(monster));
        

    }
    if (userInput == "3")
    {
        Console.WriteLine("We have these Monsters in the Database!");
        var inDatabase = monsterLogic.GetAllMonsters();
        foreach (var item in  inDatabase)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    
        Console.WriteLine("I am Van Helsing Bot!");
        Console.WriteLine("How may I help you fight the forces of evil?");
        Console.WriteLine("Press 1 to add a Monster to the database.");
        Console.WriteLine("Press 2 to view a Monster in the database.");
        Console.WriteLine("Press 3 to view all Monsters in the database.");
        Console.WriteLine("Type exit to end program.");
        userInput = Console.ReadLine();
    
}