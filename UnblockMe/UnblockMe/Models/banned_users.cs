using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class banned_users
    {
        public banned_users()
        {
        }

        public banned_users(string id, string reason, DateTime unban)
        {
            Id = id;
            this.reason = reason;
            this.unban = unban;
        }

        public banned_users(string id, string reason, DateTime unban, Users user) : this(id, reason, unban)
        {
            User = user;
        }

        public string Id { get; set; }
        public string reason { get; set; }
        public DateTime unban { get; set; }
        public virtual Users User { get; set; }
    }
}
