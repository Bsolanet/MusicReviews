namespace MusicReviews.Models;
using System.Text.Json.Serialization;

public class User
{
    [JsonPropertyName("id")]
    public int id { get; set; }
    [JsonPropertyName("username")]
    public required string username { get; set; }
    [JsonPropertyName("password")]
    public required string password { get; set; }
}