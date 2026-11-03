using System.Text.Json;
using CookieCookbook.Models.Repositories.Ingredients;
using CookieCookbook.Models.UserInteraction;
namespace CookieCookbook.Models.Repositories.Recipes;

public class RecipeStoreJson : RecipeStore
{
    protected override string FilePath { get; set; } = "./Data/ExistingRecipes.json";
    public RecipeStoreJson(IngredientStore store, IUserInteraction userInteraction) : base(store, userInteraction) {}
    protected override List<string> GetContent()
    {
        string jsonString = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<string>>(jsonString) ?? [];
    }

    protected override void SaveContent(List<string> current)
    {
        string jsonString = JsonSerializer.Serialize(current);
        File.WriteAllText(FilePath, jsonString);
    }
}