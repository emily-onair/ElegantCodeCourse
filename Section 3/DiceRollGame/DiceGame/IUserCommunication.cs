namespace DiceRollGame.DiceGame;

public interface IUserCommunication
{
    void PrintMessage(string message);
    int CollectGuess(string message);
}