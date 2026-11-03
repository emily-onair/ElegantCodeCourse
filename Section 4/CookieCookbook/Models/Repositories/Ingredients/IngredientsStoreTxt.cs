
using CookieCookbook.Models.UserInteraction;

namespace CookieCookbook.Models.Repositories.Ingredients;

public class IngredientStoreTxt : IngredientStore
{
    public IngredientStoreTxt(IUserInteraction userInteraction, string filePath) : base(userInteraction, filePath) {}

    public override void PopulateAvailableIngredients(string filePath)
    {
        if (File.Exists(filePath))
        {
            List<string> fileContent = [.. File.ReadAllLines(filePath)];
            List<Ingredient> ingredients = [];
            if (fileContent.Count % 3 == 0)
            {
                for (int i = 0; i < fileContent.Count; i += 3)
                {
                    var id = int.Parse(ExtractValue(fileContent[i]));
                    var name = ExtractValue(fileContent[i+1]);
                    var instructions = ExtractValue(fileContent[i+2]);
                    ingredients.Add(new Ingredient()
                    {
                        Id = id,
                        Name = name,
                        PreparationInstructions = instructions
                    });
                }
                AvailableIngredients = ingredients;
            }
            else _userCommunication.PrintForUser("Available ingredients could not be found");
        } else _userCommunication.PrintForUser("Available ingredients could not be found");
    }

    private string ExtractValue (string line)
    {
        return line.Split(":")[1].Trim();
    }
}