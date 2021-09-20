using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class Cars
    {

        
        [Required(ErrorMessage = "Title is required.")]
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string BlocksCar { get; set; }
        public string IsBlockedByCar { get; set; }
        public double? lat { get; set; }
        public double? lng { get; set; }
        public string OwnerId { get; set; }
        [JsonIgnore]
        public virtual Users Owner { get; set; }
        [JsonIgnore]
        public int CityId { get; set; }
    }
}
