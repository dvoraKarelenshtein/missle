using api_srevice;

using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SkadController : ControllerBase
    {
      
        public SkadController()
        {
           
        }
        SkadService service = new SkadService();
        [HttpGet]
        public IEnumerable<Skad> Get()
        {
           return  service. GetData();
        }
        [HttpGet]
        [Route("GetByCity")]
        public IEnumerable<Skad> GetCity(string city)
        {
            return service.GetData(city);
        }
        [HttpPost]
        public bool post(Skad skad)
        {   
            return service.add (skad);
        }
       
        [HttpGet]
        [Route("GetPlace")]
        public IEnumerable<Location> GetPlace()
        {
            return service.GetPlace();
        }
    }
}
