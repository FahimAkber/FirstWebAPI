using InfoAPI.Models;
using System.Collections.Generic;

namespace InfoAPI.Services
{
    public interface IInfoService
    {
        public List<Info> GetInfos();
         Info Insert(Info info);
         void Update(string id, Info info);
         void Remove(string id);
         Info GetInfo(string id);
    }
}