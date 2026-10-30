
using System.IO.Enumeration;

namespace CookieCookbook.Models;

public class NewRecipe : Recipe
{
    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }
    public void SaveToFile(JsonManager json, string fileName)
    {
        var ids = GetIngredientIds();
        json.AddNewRecipe(ids, fileName);
    }

    private string GetIngredientIds()
    {
        List<string> ids = [];
        foreach (var ingredient in Ingredients)
        {
            ids.Add(ingredient.Id.ToString());
        }
        return string.Join(",", ids);
    }

}