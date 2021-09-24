using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace UnblockMe.Models
{
    public partial class Users : IdentityUser
    {
        public Users()
        {
            Cars = new HashSet<Cars>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public byte[] ProfilePicture { get; set; }

        public virtual ICollection<Cars> Cars { get; set; }
        public virtual ICollection<Ratings> RatesGot { get; set; }
        public virtual ICollection<Ratings> RatesGiven { get; set; }
      
        public virtual banned_users Banned { get; set; }
      
    }
}
