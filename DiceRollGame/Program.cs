using DiceRollGame.DiceGame;

var dice = new Dice();
var game = new Game(dice);
var result = game.Play();
Console.WriteLine(result);



// Console.WriteLine("Number to guess is: " + DiceGame.NumberToGuess);
// var newGame = new DiceGame();
// newGame.Start();

// class DiceGame
// {
//     const int TotalTurns = 3;
//     public static readonly int NumberToGuess = new Random().Next(1, 6);
//     private bool _winner;
//     public void Start()
//     {
//         Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
//         int turns = 0;
//         do
//         {
//             var userGuess = Console.ReadLine();
//             if (int.TryParse(userGuess, out int num) && num < 7 && num > 0)
//             {
//                 turns++;
//                 if (num == NumberToGuess)
//                 {
//                     Console.WriteLine("You win! :)");
//                     _winner = true;
//                     break;
//                 }
//                 Console.WriteLine("Wrong number");
//             }
//             else
//             {
//                 Console.WriteLine("Invalid input");
//             }
//         } while (turns < TotalTurns);
//         if (!_winner) Console.WriteLine("You lose :(");
//     }
// }