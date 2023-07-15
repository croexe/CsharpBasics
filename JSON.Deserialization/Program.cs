using JSON.Deserialization.Models;
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

var options = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

string jsonFile = File.ReadAllText(@"C:\Users\Irinej\source\repos\OsnoveCsharpa\JSON.Deserialization\JohnMcStevenson.json");
Person? personRead = JsonSerializer.Deserialize<Person>(jsonFile, options);

Console.WriteLine(personRead!.LastName);
