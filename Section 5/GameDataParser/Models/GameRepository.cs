using System.Text.Json;
using GameDataParser.Models.UserInteraction;

namespace GameDataParser.Models;

public class GameRepository : IGameRepository
{
    public List<Game> Games = [];
    private readonly IUserInteraction _userInteraction;
    public GameRepository(string filename, IUserInteraction userInteraction)
    {
        var fileContent = GetGamesFromJsonFile(filename);
        if (fileContent is not null) Games = fileContent;
        _userInteraction = userInteraction;
    }

    public List<Game>? GetGamesFromJsonFile(string filename)
    {
        string jsonString = File.ReadAllText(filename);
        try {
            var json = JsonSerializer.Deserialize<List<Game>>(jsonString);
            return json;
        } catch (JsonException) {
            _userInteraction.PrintForUser($"JSON in {filename} was not in a valid format. " +
            "JSON body: ");
            _userInteraction.PrintErrorForUser(jsonString);
            throw;
        }
    }
    public void PrintGames()
    {
        foreach (var game in Games)
        {
            _userInteraction.PrintForUser(game.ToString());
        }
    }
}