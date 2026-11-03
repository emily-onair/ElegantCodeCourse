using CookieCookbook.Models.UserInteraction;

namespace CookieCookbook.Models.Repositories.Ingredients;

public abstract class IngredientStore : IIngredientStore
{
    public readonly IUserInteraction _userCommunication;

    public IngredientStore(IUserInteraction userCommunication, string filePath)
    {
        _userCommunication = userCommunication;
        PopulateAvailableIngredients(filePath);
    }
    public List<Ingredient> AvailableIngredients = [];
    public List<string> AvailableIngredientIds
    {
        get => [.. AvailableIngredients.Select(i => i.Id.ToString())];
    }

    public abstract void PopulateAvailableIngredients(string filePath);

    public void PrintAvailableIngredients()
    {
        foreach (var ingredient in AvailableIngredients)
            _userCommunication.PrintForUser(ingredient.ToString());
    }

    public Ingredient? GetIngredientById(int id)
    {
        foreach (var ingredient in AvailableIngredients)
        {
            if (ingredient.Id == id) return ingredient;
        }
        return null;
    }
}