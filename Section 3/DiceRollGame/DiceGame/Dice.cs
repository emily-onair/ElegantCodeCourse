namespace DiceRollGame.DiceGame;
public class Dice(Random random, int sides = 6) : IDice
{
    public int Sides { get; init; } = sides;
    private readonly Random _random = random;

    public int Roll()
    {
        return _random.Next(1, Sides + 1);
    }
}