using JSON.Helpers;
using JSON.Models;
using System.Text.Json;

var person = new Person
{
    Id = 1,
    //Age = 30,
    FirstName = "John",
    LastName = "McStevenson",
    IsAlive = true,
    Address = new Address
    {
        StreetName = "1 Main Street",
        City = "N.Y.",
        ZipCode = "320000"
    },
    Phones = new List<Phone>
    {
        new Phone{ PhoneType = "Home", PhoneNumber = "0673235326" },
        new Phone{ PhoneType = "Mobile", PhoneNumber = "0673347235326" }
    },
    AyeColor = "Blue",
    Height = "182"
};

var options = new JsonSerializerOptions {
    WriteIndented = true,
    PropertyNamingPolicy = new LowerCaseNamingPolicy(),
    // IncludeFields = true - > i ovdje se mogu fieldovi ukljuciti u serialiazaciju 
}; 

string json = JsonSerializer.Serialize<Person>(person, options);
string jsonFile = "JohnMcStevenson.json";

File.WriteAllText(jsonFile, json);

Console.WriteLine(File.ReadAllText(jsonFile));