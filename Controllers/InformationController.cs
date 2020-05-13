using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using InfoAPI.Models;
using InfoAPI.Services;

namespace InfoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        
        private IInformationService service;
        public InformationController(IInformationService service){
            this.service = service;
        }

       [HttpGet]
       public List<Information> Get() {
           List<Information> list = service.GetInfos();
           string name = list.First().Name;
           return list;
       }

       [HttpPost]
       public ActionResult<Information> Create(Information info){
           service.Insert(info);
           return info;
       }

       [HttpPut("{id:length(24)}")]
       public ActionResult<Information> Update(string id, Information info){
           var getInfo = service.GetInfo(id);
           if(getInfo == null){
               return NotFound();
           }
           service.Update(id, info);
           return info;
       }

       [HttpDelete("{id:length(24)}")]
       public ActionResult<Information> Delete(string id){
           var getInfo = service.GetInfo(id);
           if(getInfo == null){
               return NotFound();
           }
           service.Remove(getInfo.Id);
           return NoContent();
       }
    }
}