using DiceRollGame.UserInput;

namespace DiceRollGame.DiceGame;
public class Game
{
    private readonly Dice _dice;
    private const int AllowedTries = 3;
    public Game(Dice dice)
    {
        _dice = dice;
    }
    public Results Play()
    {
        var numberToGuess = _dice.Roll();
        Console.WriteLine($"Guess {numberToGuess}");
        Console.WriteLine($"Dice rolled. Guess what number it shows in {AllowedTries} tries.");
        int i = 0;
        while (i < AllowedTries)
        {
            var guess = ConsoleRead.ReadValidInt(_dice.Sides);
            if (guess == numberToGuess)
                return Results.Win;
            Console.WriteLine("Wrong number");
            i++;
        }
        return Results.Lose;
    }
}