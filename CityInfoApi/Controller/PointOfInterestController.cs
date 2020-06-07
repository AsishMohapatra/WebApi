using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfoApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfoApi.Controller
{
    [Route("api/cityInfo/{cityId}/PointOfInterest")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPointOfInterest(int cityId)
        {
            var cityFound = CityDataStore.Current.Cities.FirstOrDefault(city => city.Id == cityId);
            if (cityFound == null)
            {
                return NotFound();
            }
            return Ok(cityFound.PointOfInterests);
        }

        [HttpGet("{pointOfInterest}")]
        public IActionResult GetPointOfInterest(int cityId,int pointOfInterest)
        {
            var cityFound = CityDataStore.Current.Cities.FirstOrDefault(city => city.Id == cityId);
            if (cityFound == null)
            {
                return NotFound();
            }
            var pointOfInterestFound = cityFound.PointOfInterests.FirstOrDefault(point => point.Id == pointOfInterest);
            if (pointOfInterestFound == null)
            {
                return NotFound();
            }
            return Ok(pointOfInterestFound);
        }
    }
}