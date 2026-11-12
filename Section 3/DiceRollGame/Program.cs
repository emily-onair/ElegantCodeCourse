using DiceRollGame.DiceGame;

var random = new Random();

var dice = new Dice(random);
var userCommunication = new UserCommunicationConsole();
var game = new Game(dice, userCommunication);

var result = game.Play();
userCommunication.PrintMessage(result.ToString());