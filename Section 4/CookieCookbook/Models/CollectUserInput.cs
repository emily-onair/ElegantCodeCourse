namespace CookieCookbook.Models;

public class CollectUserInput
{
    public static string CollectIngredients(IngredientsStore ingredientsStore)
    {
        List<string> ids = [];
        do
        {
            Console.WriteLine("Add an ingredient by its ID. Type anything else to finish.");
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