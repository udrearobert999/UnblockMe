using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Services
{
    public class CarsService : ICarsService
    {
        private readonly UnblockMeContext _dbContext;
        public CarsService(UnblockMeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Cars> GetCarsList()
        {
            return _dbContext.Cars.ToList();
        }
        public List<Cars> GetCarsByLicensePlate(string licensePlate)
        {
            return _dbContext.Cars
                .Include(car => car.Owner)
                .Where(car => car.LicensePlate.Contains(licensePlate))
                .ToList();
        }
    }

    public interface ICarsService
    {
        public List<Cars> GetCarsList();
        public List<Cars> GetCarsByLicensePlate(string licensePlate);
    }
}
