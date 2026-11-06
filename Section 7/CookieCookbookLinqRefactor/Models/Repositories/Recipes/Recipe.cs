using CookieCookbook.Models.Repositories.Ingredients;
namespace CookieCookbook.Models.Repositories.Recipes;

public class Recipe
{
    public List<Ingredient> Ingredients { get; set; } = [];
    public override string ToString()
    {
        return string.Join(Environment.NewLine, 
            Ingredients.Select(ingredient => $"{ingredient.Name}. {ingredient.PreparationInstructions}"));
        // string stringified = "";
        // foreach (var ingredient in Ingredients)
        //     stringified += $"{ingredient.Name}. {ingredient.PreparationInstructions}" 
        //         + Environment.NewLine;
        // return stringified;
    }
}