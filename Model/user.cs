namespace MusicReviews.Models;
using System.Text.Json.Serialization;

public class Users
{
    [JsonPropertyName("id")]
    public int id { get; set; }
    [JsonPropertyName("username")]
    public string username { get; set; }
    [JsonPropertyName("password")]
    public string password { get; set; }
}