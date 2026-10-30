using CookieCookbook.Models;

string availableIngredientsFile = "./Data/AvailableIngredients.json";
var jsonManager = new JsonManager();
var AvailableIngredients = jsonManager.GetAvailableIngredients(availableIngredientsFile);
if (AvailableIngredients is null)
{
    Console.WriteLine("No available ingredients");
    return;
}

Console.WriteLine("Create a new recipe! Available ingredients are: ");
foreach (var ingredient in AvailableIngredients)
{
    ingredient.PrintIngredientAsAvailable();
}

var store = new RecipeStore();
var myRecipe = store.CollectNewRecipe(AvailableIngredients);
Console.WriteLine("THIS IS MY RECIPE: " + myRecipe);
string existingRecipesFile = "./Data/ExistingRecipes.json";
jsonManager.AddNewRecipe(myRecipe, existingRecipesFile);

