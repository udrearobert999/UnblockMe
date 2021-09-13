using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public partial class CityInfo
    {

        public CityInfo()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string County { get; set; }
        public int Population { get; set; }
        public string Auto { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int ParkedCarsNumber { get; set; }
        public int BlockedCarsNumber { get; set; }
    }
}
