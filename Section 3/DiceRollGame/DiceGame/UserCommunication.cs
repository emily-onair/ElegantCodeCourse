namespace DiceRollGame.DiceGame;

public class UserCommunicationConsole : IUserCommunication
{
    public void PrintMessage(string message)
        => Console.WriteLine(message);

    public int CollectGuess(string message)
    {
        do
        {
            PrintMessage(message);
            var guess = Console.ReadLine();
            if (int.TryParse(guess, out var num))
                return num;
        } while (true);
    }
}