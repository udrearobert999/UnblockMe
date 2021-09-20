using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Services
{
    public class BlockingsInfoService : IBlockingInfoService
    {
        private readonly ICarsService _carsService;
        private readonly IMathService _mathService;
        public BlockingsInfoService(ICarsService carsService, IMathService mathService)
        {
            _carsService = carsService;
            _mathService = mathService;
        }

        public double GetBlockingChanceOfSpot(double lat, double lng, double radius)
        {
            var cars = _carsService.GetActiveCars();
            int parkedCarsCnt = 0;
            int blockedCarsCnt = 0;

            foreach (var car in cars)
            {
                if (car.IsBlockedByCar != null)
                    blockedCarsCnt++;
                if (car.lat != null && car.lng != null)
                    parkedCarsCnt++;
                if (_mathService.ClaculateDist(
                    lat,
                    car.lat.GetValueOrDefault(),
                    lng,
                    car.lng.GetValueOrDefault()) <= 1)
                {
                    if (car.IsBlockedByCar != null)
                        blockedCarsCnt++;
                    if (car.lat != null && car.lng != null)
                        parkedCarsCnt++;

                }
            }
            if (parkedCarsCnt == 0)
                return 0;
            return blockedCarsCnt / (double)parkedCarsCnt;
        }
    }
    public interface IBlockingInfoService
    {
        public double GetBlockingChanceOfSpot(double lat, double lng, double radius);
    }
}


