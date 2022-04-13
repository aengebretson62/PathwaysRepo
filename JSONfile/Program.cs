using System.Text.Json.Serialization;
using System.Net.Http.Json;

using var client = new HttpClient();

var url = "http://webcode.me/users.json";
var data = await client.GetFromJsonAsync<Users>(url);

if (data != null)
{
    foreach (var user in data.users)
    {
        Console.WriteLine(user);
    }
}

class Users
// This is a five test
{
    public List<User> users { get; set; } = new();
}

class User
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [JsonPropertyName("last_name")]
    public string LastName { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"User {{ {Id}| {FirstName} {LastName}| {Email} }}";
    }
}