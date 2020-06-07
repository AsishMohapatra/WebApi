using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoApi.Model
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfPointOfInterest { get { return PointOfInterests.Length; } }

        public PointOfInterest[] PointOfInterests { get; set; } = new List<PointOfInterest>().ToArray();
    }

    public class PointOfInterest
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

    }
}
