using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Interface;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        private readonly IMyService _service;
        private readonly IMyService2 _service2;
        public DefaultController(IMyService service , IMyService2 service2 )
        {
            _service = service;
            _service2 = service2 ;
        }


        [HttpGet]
        public IActionResult Get()
        {
              return  Ok(_service.getString() +"______________"+  _service2.getString()) ;
        }
    }
}