using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using InfoAPI.Models;
using InfoAPI.Services;

namespace InfoAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        

        private IInfoService infoService;
        public InfoController(IInfoService infoService){
            this.infoService = infoService;
        }
        [HttpGet]
       public ActionResult<List<Info>> Get() => infoService.GetInfos();

       [HttpPost]
       public ActionResult<Info> Create(Info info){
           infoService.Insert(info);
           return info;
       }

       [HttpPut]
       public ActionResult<Info> Update(string id, Info info){
           var getInfo = infoService.GetInfo(id);
           if(getInfo == null){
               return NotFound();
           }
           infoService.Update(id, info);
           return info;
       }

       [HttpDelete]
       public ActionResult<Info> Delete(string id){
           var getInfo = infoService.GetInfo(id);
           if(getInfo == null){
               return NotFound();
           }
           infoService.Remove(getInfo.Id);
           return NoContent();
       }
    }
}