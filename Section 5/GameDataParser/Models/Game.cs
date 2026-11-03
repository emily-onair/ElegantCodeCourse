namespace GameDataParser.Models;

public class Game(string title, int releaseYear, float rating)
{
    public string Title { get; set; } = title;
    public int ReleaseYear { get; set; } = releaseYear;
    public float Rating { get; set; } = rating;
    public override string ToString() => $"{Title}, released in {ReleaseYear}, rating: {Rating}";
}