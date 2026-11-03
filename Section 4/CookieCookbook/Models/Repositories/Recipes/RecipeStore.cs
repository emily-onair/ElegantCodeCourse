using CookieCookbook.Models.Repositories.Ingredients;
using CookieCookbook.Models.UserInteraction;

namespace CookieCookbook.Models.Repositories.Recipes;

public abstract class RecipeStore : IRecipeStore
{
    protected virtual string FilePath { get; set; } = "";
    protected IUserInteraction _userInteraction;
    public RecipeStore(IngredientStore ingredientStore, IUserInteraction userInteraction, string? filePath = null)
    {
        if (filePath is not null) FilePath = filePath;
        _userInteraction = userInteraction;
        GetExistingRecipes(ingredientStore);
    }
    public List<Recipe> ExistingRecipes = [];

    protected abstract List<string> GetContent();

    protected abstract void SaveContent(List<string> current);

    public void GetExistingRecipes(IngredientStore ingredientStore)
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
            _userInteraction.PrintForUser($"*****{i + 1}*****");
            _userInteraction.PrintForUser(ExistingRecipes[i].ToString());
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