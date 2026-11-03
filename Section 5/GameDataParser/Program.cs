using GameDataParser.Models;
using GameDataParser.Models.UserInteraction;

var logger = new Logger();
var userInteraction = new UserInteractionConsole();

try {
    var filename = userInteraction.RequestFile();
    GameRepository gameStore = new(filename, userInteraction);
    gameStore.PrintGames();
} catch (Exception ex)
{
    logger.LogException(ex);
}