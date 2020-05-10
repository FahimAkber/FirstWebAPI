using InfoAPI.Models;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;

namespace InfoAPI.Services
{
    public class InfoService : IInfoService
    {

        private readonly IMongoCollection<Info> info;
        public InfoService(IInfoDataBaseSetting setting){
            var client = new MongoClient(setting.ConnectionPort);
            var database = client.GetDatabase(setting.DataBaseName);
            info = database.GetCollection<Info>(setting.CollectionName);
        }

        public List<Info> GetInfos(){
            return info.Find(info => true).ToList();
        }
        public Info Insert(Info InsertInfo){
            info.InsertOne(InsertInfo);
            return InsertInfo;
        }
        public void Update(string id, Info updateInfo){
            info.ReplaceOne(info => info.Id == id, updateInfo);
        }
        public void Remove(string id){
            info.DeleteOne(info => info.Id == id);
        }
        public Info GetInfo(string id){
            return info.Find(info => info.Id == id).FirstOrDefault();

        }

    }
}