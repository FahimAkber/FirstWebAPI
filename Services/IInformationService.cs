using InfoAPI.Models;
using System.Collections.Generic;

namespace InfoAPI.Services
{
    public interface IInformationService
    {
        public List<Information> GetInfos();
         Information Insert(Information info);
         void Update(string id, Information info);
         void Remove(string id);
         Information GetInfo(string id);
    }
}