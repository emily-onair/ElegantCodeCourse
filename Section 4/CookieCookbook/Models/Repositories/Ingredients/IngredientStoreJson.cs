using System.Text.Json;
using CookieCookbook.Models.UserInteraction;

namespace CookieCookbook.Models.Repositories.Ingredients;

public class IngredientStoreJson : IngredientStore
{
    public IngredientStoreJson(IUserInteraction userInteraction, string filePath) : base(userInteraction, filePath) {}

    public override void PopulateAvailableIngredients(string filePath)
    {
        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            var json = JsonSerializer.Deserialize<List<Ingredient>>(jsonString);
            if (json is not null)
                AvailableIngredients = json;
            else
                _userCommunication.PrintForUser("Available ingredients could not be found");
        } else
        {
            _userCommunication.PrintForUser("Available ingredients could not be found");
        }
    }
}