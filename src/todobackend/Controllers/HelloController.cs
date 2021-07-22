using System;
using Microsoft.AspNetCore.Mvc;

namespace todobackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {


        [HttpGet]
        public String Get()
        {
            return "Ola mundo";
        }
    }
}
