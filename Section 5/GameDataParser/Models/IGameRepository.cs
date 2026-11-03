using GameDataParser.Models.UserInteraction;

namespace GameDataParser.Models;

public interface IGameRepository
{
    public List<Game>? GetGamesFromJsonFile(string filename);
    public void PrintGames();
}