using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoApi
{
    [ApiController]
    [Route("api/cities")]
    public class CityInfoController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new{ Id=1,Name="Bhubaneswar" },
                new{ Id=1,Name="Cuttack" }
            }
            );
        }
    }
}
