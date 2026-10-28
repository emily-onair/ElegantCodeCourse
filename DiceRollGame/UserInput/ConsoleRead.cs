namespace DiceRollGame.UserInput;
public class ConsoleRead
{
    public static int ReadValidInt (int sides)
    {
        do
        {
            if (int.TryParse(Console.ReadLine(), out var num) && num < sides + 1 && num > 0)
                return num;
            Console.WriteLine("Invalid input");
        } while (true);
    }
}