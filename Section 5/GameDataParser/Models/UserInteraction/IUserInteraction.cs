using System.Diagnostics.CodeAnalysis;

namespace GameDataParser.Models.UserInteraction;

public interface IUserInteraction
{
    public string RequestFile();
    public bool ValidateInput([NotNullWhen(true)] string? input);
    public abstract void PrintForUser(string message);
    public abstract void PrintErrorForUser(string message);
    public abstract string? CollectUserInput();
}