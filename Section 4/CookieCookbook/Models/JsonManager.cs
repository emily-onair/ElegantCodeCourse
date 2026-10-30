using System.Text.Json;

namespace CookieCookbook.Models;

public class JsonManager
{
    public List<Ingredient>? GetAvailableIngredients(string fileName)
    {
        if (File.Exists(fileName))
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<Ingredient>>(jsonString);    
        }
        return null;
    }

    public List<string>? GetExistingRecipes(string fileName)
    {
        if (File.Exists(fileName))
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<string>>(jsonString);
        }
        return null;
    }
    public void AddNewRecipe(string newRecipeIds, string fileName)
    {
        var existingRecipes = GetExistingRecipes(fileName);
        if (existingRecipes is not null)
        {
            existingRecipes.Add(newRecipeIds);
            string jsonString = JsonSerializer.Serialize(existingRecipes);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }
    }
}