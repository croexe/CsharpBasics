using JSON.Deserialization.Models;
using System.Text.Json;

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

string jsonFile = File.ReadAllText("JohnMcStevenson.json");
Person? personRead = JsonSerializer.Deserialize<Person>(jsonFile, options);

Console.WriteLine(personRead!.LastName);
