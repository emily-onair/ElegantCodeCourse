using System.Diagnostics.CodeAnalysis;

namespace GameDataParser.Models.UserInteraction;

public abstract class UserInteraction : IUserInteraction
{
    public string RequestFile()
    {
        do {
            PrintForUser("Enter the name of the file you want to read:");
            var userInput = CollectUserInput();
            if (ValidateInput(userInput) is true) return userInput;
        } while (true);
    }

    public bool ValidateInput([NotNullWhen(true)] string? input)
    {
        if (input is null)
        {
            PrintForUser("File name cannot be null.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(input))
        {
            PrintForUser("File name cannot be empty.");
            return false;
        }
        if (!File.Exists(input))
        {
            PrintForUser("File not found.");
            return false;
        }
        return true;
    }

    public abstract void PrintForUser(string message);
    public abstract void PrintErrorForUser(string message);
    public abstract string? CollectUserInput();
}