using GameDataParser.Models;

var logger = new Logger();

try {
    var filename = UserInteraction.RequestFile();
    var gameStore = new GameRepository(filename);
    gameStore.PrintGames();
} catch (Exception ex)
{
    logger.LogException(ex);
}