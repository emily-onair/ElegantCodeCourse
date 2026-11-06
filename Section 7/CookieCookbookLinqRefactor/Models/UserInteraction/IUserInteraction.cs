using CookieCookbook.Models.Repositories.Ingredients;

namespace CookieCookbook.Models.UserInteraction;

public interface IUserInteraction
{
    public void PrintForUser(string message);
    public string CollectIngredients(IngredientStore ingredientStore);
}