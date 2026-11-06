namespace CookieCookbook.Models.Repositories.Ingredients;

public interface IIngredientStore {
    public void PopulateAvailableIngredients(string filepath);
    public Ingredient? GetIngredientById(int id);
    public void PrintAvailableIngredients();
}