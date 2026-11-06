using CookieCookbook.Models.Repositories.Ingredients;
namespace CookieCookbook.Models.Repositories.Recipes;

interface IRecipeStore
{
    public void GetExistingRecipes(IngredientStore ingredientsStore);
    public void PrintExistingRecipes();
    public void AddNewRecipe(string ids);
}