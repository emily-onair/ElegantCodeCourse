namespace DiceRollGame.DiceGame;
public class Dice
{
    public int Sides { get; init; }
    public Dice (int sides = 6)
    {
        Sides = sides;
    }

    public int Roll()
    {
        return new Random().Next(1, Sides + 1);
    }
}