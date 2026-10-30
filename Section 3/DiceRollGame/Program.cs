using DiceRollGame.DiceGame;

var dice = new Dice();
var game = new Game(dice);
var result = game.Play();
Console.WriteLine(result);



var newGame = new DiceGame();
newGame.Start();

class DiceGame
{
    const int TotalTurns = 3;
    private bool _winner;
    public void Start()
    {
        int numberToGuess = RollDice();
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        int turns = 0;
        do
        {
            var userGuess = Console.ReadLine();
            if (int.TryParse(userGuess, out int num) && num < 7 && num > 0)
            {
                turns++;
                if (num == numberToGuess)
                {
                    Console.WriteLine("You win! :)");
                    _winner = true;
                    break;
                }
                Console.WriteLine("Wrong number");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        } while (turns < TotalTurns);
        if (!_winner) Console.WriteLine("You lose :(");
    }

    private static int RollDice()
    {
        return new Random().Next(1, 7);
    }
}