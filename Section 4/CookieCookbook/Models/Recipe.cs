namespace CookieCookbook.Models;

public class Recipe
{
    public List<Ingredient> Ingredients { get; set; } = [];
    public void PrintRecipe(int i)
    {
        Console.WriteLine($"*****{i}*****");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"{ingredient.Name}. {ingredient.PreparationInstructions}");
        }
        Console.WriteLine();
    }
}