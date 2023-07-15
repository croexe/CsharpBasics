using System.Text.Json;

using HttpClient client = new()
{
    BaseAddress = new Uri("http://localhost:5062")
};

var response = await client.GetAsync("/weatherforecast");

if (response.IsSuccessStatusCode)
{
    var jsonString = await response.Content.ReadAsStringAsync();
    using(JsonDocument jsonDocument = JsonDocument.Parse(jsonString))
    {
        JsonElement root = jsonDocument.RootElement;
        Console.WriteLine($"{root.ValueKind}, {root.ToString()}");
        foreach(var temp in root.EnumerateArray())
        {
            Console.WriteLine($"Summary: {temp.GetProperty("summary")}");
        }
    }
}
else
{
    Console.WriteLine($"Something went wrong! Error: {response.StatusCode}");
}
