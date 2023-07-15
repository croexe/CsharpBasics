using JSON.Models;
using System.Text.Json;

var person = new Person
{
    Id = 1,
    Age = 30,
    FirstName = "John",
    LastName = "McStevenson",
    IsAlive = true,
};

var options = new JsonSerializerOptions {
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
}; 

string json = JsonSerializer.Serialize<Person>(person, options);
string jsonFile = "JohnMcStevenson.json";

File.WriteAllText(jsonFile, json);

Console.WriteLine(File.ReadAllText(jsonFile));