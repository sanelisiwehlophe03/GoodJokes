using System.Media;
Console.WriteLine(@"  ___   __    __  ____      __   __  __ _  ____  ____ 
 / __) /  \  /  \(    \   _(  ) /  \(  / )(  __)/ ___)
( (_ \(  O )(  O )) D (  / \) \(  O ))  (  ) _) \___ \
 \___/ \__/  \__/(____/  \____/ \__/(__\_)(____)(____/");
Console.WriteLine("--------------------------------");

while (true)
{
    // Ask user for joke type
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nWhat kind of joke do you want?");
    Console.WriteLine("Choose between: Tech, Dad or Animal joke");
    Console.Write("Enter your choice: ");

    string choice = Console.ReadLine();

    if (choice != "Exit")
        

    choice = choice.ToLower();

    Console.WriteLine();

    // TECH JOKE
    if (choice.Contains("tech"))
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("*** JOKE ***");
        Console.WriteLine();
        Console.WriteLine("Executing Tech_Humor.exe...");
        Console.WriteLine();

        try
        {
            SoundPlayer player = new SoundPlayer("tech.wav");
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
            
        }

        Console.WriteLine( "Why do programmers prefer dark mode?\n " + "Because light attracts bugs." );
    }

    // DAD JOKE
    else if (choice.Contains("dad"))
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("Activating Dad_Mode...");
        Console.WriteLine();
        Console.WriteLine("*** JOKE ***");
        Console.WriteLine();
        Console.WriteLine("Hi Hungry, I'm Dad.");

        try
        {
            SoundPlayer player = new SoundPlayer("dad.wav");
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
        }
    }

    // ANIMAL JOKE
    else if (choice.Contains("animal"))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("*** JOKE ***");
        Console.WriteLine();

        try
        {
            SoundPlayer player = new SoundPlayer("animal.wav");
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
        }
        Console.WriteLine("Why don't scientists trust atoms? \n" +"Because they make up everything!" );
    }

    // INVALID CHOICE
    else
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Sorry, I don't understand that choice.");
        Console.WriteLine("Please choose Tech, Dad or Animal.");
    }

    // Ask whether the user wants another joke
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("What kind of joke do you want?");
    Console.WriteLine("Choose between: Tech, Dad or Animal joke");
    Console.Write("Enter your choice: ");
}
