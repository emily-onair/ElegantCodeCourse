namespace GameDataParser.Models.UserInteraction;

public class UserInteractionConsole : UserInteraction
{
    public override void PrintForUser(string message)
    {
        Console.WriteLine(message);
    }

    public override void PrintErrorForUser(string message)
    {
        var temp = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = temp;
    }

    public override string? CollectUserInput()
    {
        return Console.ReadLine();
    }
}