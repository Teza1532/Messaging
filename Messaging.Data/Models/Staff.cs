using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messaging.Data.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }
        public DateTime LastUpdated { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public bool deleted { get; set; }
    }
}
