namespace CookieCookbook.Models.Repositories;

interface IRecipeStore
{
    public void GetExistingRecipes(IngredientsStore ingredientsStore);
    public void PrintExistingRecipes();
    public void AddNewRecipe(string ids);
}