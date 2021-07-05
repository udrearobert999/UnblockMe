using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UnblockMe.Models
{
    public partial class Users : IdentityUser
    {
        public Users()
        {
            Cars = new HashSet<Cars>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Passowrd { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
    }
}
