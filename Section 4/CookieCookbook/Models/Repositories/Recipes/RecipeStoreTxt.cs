using CookieCookbook.Models.Repositories.Ingredients;
using CookieCookbook.Models.UserInteraction;
namespace CookieCookbook.Models.Repositories.Recipes;

public class RecipeStoreTxt : RecipeStore
{
    protected override string FilePath { get; set; } = "./Data/ExistingRecipes.txt";
    public RecipeStoreTxt(IngredientStore store, IUserInteraction userInteraction) : base(store, userInteraction) {}
    protected override List<string> GetContent() => [.. File.ReadAllLines(FilePath)];

    protected override void SaveContent(List<string> current) => File.WriteAllLines(FilePath, current);
}