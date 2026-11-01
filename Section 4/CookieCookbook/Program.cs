using CookieCookbook.Models;



const FileType fileType = FileType.Json;

var ingredientsStore = new IngredientsStore();

IRecipeStore recipeStore;
if (fileType == FileType.Json)
    recipeStore = new RecipeStoreJson(ingredientsStore);
// else
//     recipeStore = new RecipeStoreText();

recipeStore.PrintExistingRecipes();

Console.WriteLine("Create a new recipe! Available ingredients are: ");
Console.WriteLine();
ingredientsStore.PrintAvailableIngredients();

string recipeToAdd = CollectUserInput.CollectIngredients(ingredientsStore);
recipeStore.AddNewRecipe(recipeToAdd);



// string availableIngredientsFile = "./Data/AvailableIngredients.json";
// var jsonManager = new JsonManager();
// var AvailableIngredients = jsonManager.GetAvailableIngredients(availableIngredientsFile);
// if (AvailableIngredients is null)
// {
//     Console.WriteLine("No available ingredients");
//     return;
// }

// Console.WriteLine("Create a new recipe! Available ingredients are: ");
// foreach (var ingredient in AvailableIngredients)
// {
//     ingredient.PrintIngredientAsAvailable();
// }

// var store = new RecipeStore();
// var myRecipe = store.CollectNewRecipe(AvailableIngredients);
// Console.WriteLine("THIS IS MY RECIPE: " + myRecipe);
// string existingRecipesFile = "./Data/ExistingRecipes.json";
// jsonManager.AddNewRecipe(myRecipe, existingRecipesFile);

