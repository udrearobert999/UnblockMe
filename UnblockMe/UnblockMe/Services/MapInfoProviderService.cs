using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Services
{
    public class MapInfoProviderService : IMapInfoProviderService
    {

        private readonly UnblockMeContext _dbContext;

        public MapInfoProviderService(UnblockMeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public string[] GetCountyRegions(string county)
        {
            var cities = _dbContext.CityInfo.Where(c=>c.County==county).Select(c=>c.Name).ToArray();
            return cities;
        }

        public CityInfo GetCityInfo(string cityName)
        {
            var city = _dbContext.CityInfo.Where(c => c.Name == cityName).ToList().First();
            return city;
        }
    }

    public interface IMapInfoProviderService
    {
        string[] GetCountyRegions(string county);
        CityInfo GetCityInfo(string cityName);
      
    }
}
