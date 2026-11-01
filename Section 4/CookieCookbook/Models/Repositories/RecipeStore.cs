using System.Text.Json;

namespace CookieCookbook.Models.Repositories;

public abstract class RecipeStore : IRecipeStore
{
    protected virtual string FilePath { get; set; } = "";
    public RecipeStore(IngredientsStore ingredientStore): this(ingredientStore, null) {}
    public RecipeStore(IngredientsStore ingredientStore, string? str)
    {
        if (str is not null) FilePath = str;
        GetExistingRecipes(ingredientStore);
    }
    public List<Recipe> ExistingRecipes = [];

    protected abstract List<string> GetContent();

    protected abstract void SaveContent(List<string> current);

    public void GetExistingRecipes(IngredientsStore ingredientStore)
    {
        if (File.Exists(FilePath) is false) return;
        var content = GetContent();
        foreach (var ingredientIds in content)
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
    public void PrintExistingRecipes()
    {
        for (int i = 0; i < ExistingRecipes.Count; i++)
        {
            ExistingRecipes[i].PrintRecipe(i + 1);
        }
    }
    
    public void AddNewRecipe(string ids)
    {
        List<string> current = [];
        if (File.Exists(FilePath))
            current = GetContent();
        current.Add(ids);
        SaveContent(current);
    }
}