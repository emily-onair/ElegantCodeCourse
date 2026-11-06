using System.Data.Common;
using CookieCookbook.Models.UserInteraction;

namespace CookieCookbook.Models.Repositories.Ingredients;

public class IngredientStoreTxt(IUserInteraction userInteraction, string filePath) : IngredientStore(userInteraction, filePath), IngredientStore
{
    public override void PopulateAvailableIngredients(string filePath)
    {
        if (File.Exists(filePath))
        {
            List<string> fileContent = [.. File.ReadAllLines(filePath)];
            if (fileContent.Count % 3 == 0)
            {
                AvailableIngredients = fileContent.Select(line => new Ingredient()
                    {
                        IdentifierCase = int.Parse(ExtractValue(fileContent[i])),
                        Name = ExtractValue(fileContent[i+1]),
                        PreparationInstructions = ExtractValue(fileContent[i+2])
                    }
                );
                // List<Ingredient> ingredients = [];
                // for (int i = 0; i < fileContent.Count; i += 3)
                // {
                //     var id = int.Parse(ExtractValue(fileContent[i]));
                //     var name = ExtractValue(fileContent[i+1]);
                //     var instructions = ExtractValue(fileContent[i+2]);
                //     ingredients.Add(new Ingredient()
                //     {
                //         Id = id,
                //         Name = name,
                //         PreparationInstructions = instructions
                //     });
                // }
                // AvailableIngredients = ingredients;
            }
            else _userCommunication.PrintForUser("Available ingredients could not be found");
        } else _userCommunication.PrintForUser("Available ingredients could not be found");
    }

    private static string ExtractValue (string line)
    {
        return line.Split(":")[1].Trim();
    }
}