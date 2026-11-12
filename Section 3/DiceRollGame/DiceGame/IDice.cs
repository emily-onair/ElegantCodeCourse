namespace DiceRollGame.DiceGame;

public interface IDice
{
    int Roll();
    int Sides { get; init; }
}