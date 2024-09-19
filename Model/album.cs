namespace MusicReviews.Models;
using System.Text.Json.Serialization;

public class Album
{
    [JsonPropertyName("image")]
    public string? Image { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    public string toString()
    {
        return $"{Title} by {Artist}";
    }
}