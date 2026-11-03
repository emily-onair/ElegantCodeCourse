using CookieCookbook.Models.Repositories.Ingredients;
namespace CookieCookbook.Models.UserInteraction;

public class UserInteractionConsole : IUserInteraction
{
    public void PrintForUser(string message)
    {
        Console.WriteLine(message);
    }

    public string CollectIngredients(IngredientStore ingredientsStore)
    {
        List<string> ids = [];
        do
        {
            PrintForUser("Add an ingredient by its ID. Type anything else to finish.");
            var userInput = Console.ReadLine();
            // check if valid int
            if (int.TryParse(userInput, out int res))
            {
                // check if existing ingredient
                if (ingredientsStore.AvailableIngredientIds.Contains(userInput))
                    ids.Add(userInput);
            }
            else break;
        } while (true);
        return string.Join(",", ids);
    }
}