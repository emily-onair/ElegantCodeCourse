using CookieCookbook.Models;
using CookieCookbook.Models.Repositories;



const FileType fileType = FileType.Json;

var ingredientsStore = new IngredientsStore();

IRecipeStore recipeStore = fileType == FileType.Json 
    ? new RecipeStoreJson(ingredientsStore) 
    : new RecipeStoreTxt(ingredientsStore);

recipeStore.PrintExistingRecipes();

Console.WriteLine("Create a new recipe! Available ingredients are: ");
Console.WriteLine();
ingredientsStore.PrintAvailableIngredients();

string recipeToAdd = CollectUserInput.CollectIngredients(ingredientsStore);
recipeStore.AddNewRecipe(recipeToAdd);