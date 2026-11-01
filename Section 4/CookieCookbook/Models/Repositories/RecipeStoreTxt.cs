namespace CookieCookbook.Models.Repositories;

public class RecipeStoreTxt : RecipeStore
{
    protected override string FilePath { get; set; } = "./Data/ExistingRecipes.txt";
    public RecipeStoreTxt(IngredientsStore store) : base(store) {}
    protected override List<string> GetContent() => [.. File.ReadAllLines(FilePath)];

    protected override void SaveContent(List<string> current) => File.WriteAllLines(FilePath, current);
}