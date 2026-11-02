using System.Diagnostics.CodeAnalysis;

namespace GameDataParser.Models;

public static class UserInteraction
{
    public static string RequestFile()
    {
        do {
            Console.WriteLine("Enter the name of the file you want to read:");
            var userInput = Console.ReadLine();
            if (ValidateInput(userInput) is true) return userInput;
        } while (true);
    }

    private static bool ValidateInput([NotNullWhen(true)] string? input)
    {
        if (input is null)
        {
            Console.WriteLine("File name cannot be null.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("File name cannot be empty.");
            return false;
        }
        if (!File.Exists(input))
        {
            Console.WriteLine("File not found.");
            return false;
        }
        return true;
    }
}