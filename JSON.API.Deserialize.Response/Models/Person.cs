using System.Text.Json.Serialization;

namespace JSON.API.Deserialize.Response.Models
{
    public class Person
    {
        public int Id { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Age { get; set; }
        [JsonPropertyName("surName")]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [JsonIgnore]
        public bool IsAlive { get; set; }
        public Address? Address { get; set; }
        public List<Phone> Phones { get; set; }

        public string AyeColor;
        [JsonInclude]
        public string Height;
    }
}
