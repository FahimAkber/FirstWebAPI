using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace InfoAPI.Models
{
    public class Info
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id;
        public string Name;
        public string Relation;
        public int age;
    }
}