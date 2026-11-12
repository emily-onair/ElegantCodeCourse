namespace DiceRollGame.DiceGame;
using DiceRollGame;
public class Game(IDice dice, IUserCommunication userCommunication) : IGame
{
    private readonly IDice _dice = dice;
    private const int AllowedTries = 3;
    private IUserCommunication _userCommunication = userCommunication;

    public Results Play()
    {
        var numberToGuess = _dice.Roll();
        _userCommunication.PrintMessage(string.Format(Resources.Greeting, AllowedTries));
        int i = 0;
        while (i < AllowedTries)
        {
            var guess = _userCommunication.CollectGuess("Enter a number: ");
            if (guess < 1 || guess > _dice.Sides)
                continue;
            if (guess == numberToGuess)
                return Results.Win;
            _userCommunication.PrintMessage("Wrong number");
            i++;

        }
        return Results.Lose;
    }
}