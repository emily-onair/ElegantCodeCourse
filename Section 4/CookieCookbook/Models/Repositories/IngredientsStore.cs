using System.Text.Json;

namespace CookieCookbook.Models;

public class IngredientsStore
{
    private readonly string _filePath = "./Data/AvailableIngredients.json";

    public IngredientsStore(): this(null) {}
    public IngredientsStore(string? str)
    {
        if (str is not null) _filePath = str;
        GetAvailableIngredients();
    }
    public List<Ingredient> AvailableIngredients = [];
    public List<string> AvailableIngredientIds
    {
        get => [.. AvailableIngredients.Select(i => i.Id.ToString())];
    }
    private void GetAvailableIngredients()
    {
        if (File.Exists(_filePath))
        {
            string jsonString = File.ReadAllText(_filePath);
            var json = JsonSerializer.Deserialize<List<Ingredient>>(jsonString);
            if (json is not null)
                AvailableIngredients = json;
            else
                Console.WriteLine("Available ingredients could not be found.");
        }
    }

    public void PrintAvailableIngredients()
    {
        foreach (var ingredient in AvailableIngredients)
        {
            ingredient.PrintIngredientAsAvailable();
        }
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