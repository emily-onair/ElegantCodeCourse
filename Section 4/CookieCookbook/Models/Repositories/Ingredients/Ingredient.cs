namespace CookieCookbook.Models.Repositories.Ingredients;

public class Ingredient
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public string PreparationInstructions { get; init; } = "";
    public override string ToString()
    {
        return $"{Id}. {Name}";
    }
}