using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InfoAPI.Models
{
    public class Information
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id{get; set;}
        public string Name{get; set;}
        public string Relation{get; set;}
        [BsonElement("Age")]
        public int age{get; set;}
    }
}