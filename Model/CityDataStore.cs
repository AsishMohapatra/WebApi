using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoApi.Model
{
    public class CityDataStore
    {
        public static CityDataStore Current { get; } = new CityDataStore();

        public IEnumerable<CityDto> Cities { get; }
        public CityDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto {
                    Id=1,
                    Name="Bhubaneswar" ,
                    Description ="Temple City",
                    PointOfInterests=new List<PointOfInterest>()
                    {
                        new  PointOfInterest(){ Id=1,Name="Lingaraj temple",Description="Lord Shiva"},
                        new  PointOfInterest(){ Id=2,Name="NandanaKanan",Description="Zoo"}
                    }.ToArray() 
                },
                new CityDto { Id=2,Name="Cuttack",Description = "Old Capital" ,
                    PointOfInterests=new List<PointOfInterest>()
                    {
                        new  PointOfInterest(){ Id=1,Name="Mahanadi",Description="Odisha biggest River"},
                        new  PointOfInterest(){ Id=2,Name="Barabati",Description="Cricket Stadium"}
                    }.ToArray()
                },
                new CityDto { Id=3,Name="Puri",Description = "Puri Temple Capital",
                PointOfInterests=new List<PointOfInterest>()
                    {
                        new  PointOfInterest(){ Id=1,Name="Samudra",Description="Beach"},
                        new  PointOfInterest(){ Id=2,Name="Sun temple",Description="Konark"}
                    }.ToArray()
                }
            };
        }
    }
}
