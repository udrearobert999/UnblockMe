using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public partial class Ratings
    {
        public string rater_id { get; set; }
        public string rated_id { get; set; }
        public string rating_message { get; set; }
        public double rating_value { get; set; }
        public virtual Users Rater { get; set; }
        public virtual Users Rated { get; set; }
    }
}
