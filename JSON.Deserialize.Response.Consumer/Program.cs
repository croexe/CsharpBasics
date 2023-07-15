using JSON.Deserialize.Response.Consumer.Models;
using System.Text.Json;

var opt = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

using HttpClient client = new()
{
    BaseAddress = new Uri("http://localhost:5062")
};

var response = await client.GetAsync("/weatherforecast");

if (response.IsSuccessStatusCode)
{
    var json = await JsonSerializer.DeserializeAsync<Temperature[]>(await response.Content.ReadAsStreamAsync(), opt);
    if (json.Any())
    {
        foreach (var temp in json)
        Console.WriteLine($"Summary: {temp.summary}");
    }
} else
{
    Console.WriteLine($"Something went wrong! Error: {response.StatusCode}");
}