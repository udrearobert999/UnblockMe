using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Services
{
    public class MathService : IMathService
    {
        public double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }
        public double ClaculateDist(double lat1,double lat2,double lon1,double lon2)
        {
           
            var R = 6371; // Radius of the earth in km
            var dLat = ConvertToRadians(lat2 - lat1);  // deg2rad below
            var dLon = ConvertToRadians(lon2 - lon1);
            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ConvertToRadians(lat1)) * Math.Cos(ConvertToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = R * c; // Distance in km
            return d;

        }

 
    }

    public interface IMathService
    {
        public double ConvertToRadians(double angle);
        public double ClaculateDist(double lat1, double lat2, double lon1, double lon2);
    }
}
