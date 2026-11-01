using System.Text.Json;

namespace CookieCookbook.Models;

public class RecipeStoreJson : IRecipeStore
{
    private readonly string _filePath = "./Data/ExistingRecipes.json";
    public RecipeStoreJson(IngredientsStore ingredientStore): this(ingredientStore, null) {}
    public RecipeStoreJson(IngredientsStore ingredientStore, string? str)
    {
        if (str is not null) _filePath = str;
        GetExistingRecipes(ingredientStore);
    }
    public List<Recipe> ExistingRecipes = [];

    private List<string>? GetJson()
    {
        string jsonString = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<string>>(jsonString);
    }

    private void SaveJson(List<string> current)
    {
        string jsonString = JsonSerializer.Serialize(current);
        Console.WriteLine($"JSON STRING: {jsonString}");
        File.WriteAllText(_filePath, jsonString);
    }
    public void GetExistingRecipes(IngredientsStore ingredientStore)
    {
        var json = GetJson();
        if (json is not null)
        {
            foreach (var ingredientIds in json)
            {
                var recipeToAdd = new Recipe();
                var ids = ingredientIds.Split(",");
                foreach (var id in ids)
                {
                    if (int.TryParse(id, out int idAsInt))
                    {
                        var foundIngredient = ingredientStore.GetIngredientById(idAsInt);
                        if (foundIngredient is not null) 
                            recipeToAdd.Ingredients.Add(foundIngredient);
                    }
                }
                if (recipeToAdd.Ingredients.Count > 0) 
                    ExistingRecipes.Add(recipeToAdd);
            }
        }
        else
            Console.WriteLine("Existing recipes could not be found.");
    }
    public void PrintExistingRecipes()
    {
        for (int i = 0; i < ExistingRecipes.Count; i++)
        {
            ExistingRecipes[i].PrintRecipe(i + 1);
        }
    }
    
    public void AddNewRecipe(string ids)
    {
        var currentJson = GetJson();
        if (currentJson is not null)
            currentJson.Add(ids);
        else
            currentJson = [ids];
        SaveJson(currentJson);
    }

    // public string CollectNewRecipe(List<Ingredient> availableIngredients)
    // {
    //     List<string> ids = [];
    //     do
    //     {
    //         Console.WriteLine("Add an ingredient by its ID. Type anything else to finish.");
    //         if (int.TryParse(Console.ReadLine(), out int userInput))
    //         {
    //             foreach (var ingredient in availableIngredients)
    //             {
    //                 if (ingredient.Id == userInput)
    //                 {
    //                     ids.Add(userInput.ToString());
    //                     break;
    //                 }
    //             }
    //         }
    //         else break;
    //     } while (true);
    //     return string.Join(",", ids);
    // }
}