using CookieCookbook.Models;
using CookieCookbook.Models.Repositories.Ingredients;
using CookieCookbook.Models.Repositories.Recipes;
using CookieCookbook.Models.UserInteraction;



const FileType fileType = FileType.Text;
const string ingredientsFilePath = fileType == FileType.Json 
    ? "./Data/AvailableIngredients.json" 
    : "./Data/AvailableIngredients.txt";

var userInteraction = new UserInteractionConsole();

IngredientStore ingredientStore = fileType == FileType.Json 
    ? new IngredientStoreJson(userInteraction, ingredientsFilePath)
    : new IngredientStoreTxt(userInteraction, ingredientsFilePath);

IRecipeStore recipeStore = fileType == FileType.Json 
    ? new RecipeStoreJson(ingredientStore, userInteraction) 
    : new RecipeStoreTxt(ingredientStore, userInteraction);

recipeStore.PrintExistingRecipes();

userInteraction.PrintForUser("Create a new recipe! Available ingredients are: ");
ingredientStore.PrintAvailableIngredients();


string recipeToAdd = userInteraction.CollectIngredients(ingredientStore);
recipeStore.AddNewRecipe(recipeToAdd);