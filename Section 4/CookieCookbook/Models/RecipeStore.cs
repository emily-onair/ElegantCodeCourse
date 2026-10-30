namespace CookieCookbook.Models;

public class RecipeStore
{
    public List<Recipe> CurrentRecipes { get; set; } = [];
    public void PrintAvailableRecipes(List<Recipe> recipes)
    {
        
    }

    public string CollectNewRecipe(List<Ingredient> availableIngredients)
    {
        List<string> ids = [];
        do
        {
            Console.WriteLine("Add an ingredient by its ID. Type anything else to finish.");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                foreach (var ingredient in availableIngredients)
                {
                    if (ingredient.Id == userInput)
                    {
                        ids.Add(userInput.ToString());
                        break;
                    }
                }
            }
            else break;
        } while (true);
        return string.Join(",", ids);
    }
}