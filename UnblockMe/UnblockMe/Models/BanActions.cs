using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models
{
    public class BanActions
    {
        public BanActions()
        {
            Id = Guid.NewGuid().ToString();
        }
        public BanActions(banned_users partialBan)
        {
            Id = Guid.NewGuid().ToString();
            Reason = partialBan.reason;
            BanEnd = partialBan.unban;
            BannedId = partialBan.Id;
        }

        public string Id { get; set; }
        public string BannedId { get; set; }
        public string BannedBy { get; set; }
        public string Reason { get; set; }
        public DateTime BanStart { get; set; }
        public DateTime BanEnd { get; set; }
    }
}
