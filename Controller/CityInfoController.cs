using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfoApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityInfoController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CityDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityFound= CityDataStore.Current.Cities.FirstOrDefault(city => city.Id == id);
            if (cityFound == null)
                return NotFound();
            else
                return Ok(cityFound);
        }
    }
}