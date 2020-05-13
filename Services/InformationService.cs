using InfoAPI.Models;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;

namespace InfoAPI.Services
{
    public class InformationService : IInformationService
    {

        private readonly IMongoCollection<Information> collection;
        public InformationService(IInformationDataBaseSetting setting){
            var client = new MongoClient(setting.ConnectionPort);
            var database = client.GetDatabase(setting.DataBaseName);
            collection = database.GetCollection<Information>(setting.CollectionName);
        }

        public List<Information> GetInfos(){
            List<Information> list =  collection.Find(info => true).ToList();
            return list;
        }
        public Information Insert(Information InsertInfo){
            collection.InsertOne(InsertInfo);
            return InsertInfo;
        }
        public void Update(string id, Information updateInfo){
            collection.ReplaceOne(info => info.Id == id, updateInfo);
        }
        public void Remove(string id){
            collection.DeleteOne(info => info.Id == id);
        }
        public Information GetInfo(string id){
            return collection.Find(info => info.Id == id).FirstOrDefault();

        }

    }
}