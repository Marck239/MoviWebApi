using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace MoviWebApi.Models
{
    public class Car
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("Model")]
        [JsonPropertyName("Model")]
        public string Model { get; set; } = null!;

        public decimal Price { get; set; }
        [JsonPropertyName("Type")]
        public string type { get; set; } = null!;

        public string Brand { get; set; } = null!;
    }
}
