using System.Text.Json;

namespace GameDataParser.Models;

public class GameRepository
{
    public List<Game> Games = [];
    public GameRepository(string filename)
    {
        var fileContent = GetGamesFromJsonFile(filename);
        if (fileContent is not null) Games = fileContent;
    }

    private static List<Game>? GetGamesFromJsonFile(string filename)
    {
        string jsonString = File.ReadAllText(filename);
        try {
            var json = JsonSerializer.Deserialize<List<Game>>(jsonString);
            return json;
        } catch (JsonException) {
            Console.WriteLine($"JSON in {filename} was not in a valid format. " +
            "JSON body: ");
            Console.WriteLine(jsonString);
            throw;
        }
    }
    public void PrintGames()
    {
        foreach (var game in Games)
        {
            game.PrintGame();
        }
    }
}