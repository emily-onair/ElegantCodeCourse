using System.Text.Json;

namespace CookieCookbook.Models.Repositories;

public class RecipeStoreJson : RecipeStore
{
    protected override string FilePath { get; set; } = "./Data/ExistingRecipes.json";
    public RecipeStoreJson(IngredientsStore store) : base(store) {}
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