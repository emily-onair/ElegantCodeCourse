namespace CookieCookbook.Models;

public class Ingredient
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public string PreparationInstructions { get; init; } = "";
    public void PrintIngredientAsAvailable()
    {
        Console.WriteLine($"{Id}. {Name}");
    }
}