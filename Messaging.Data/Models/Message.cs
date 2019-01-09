using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messaging.Data.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string message { get; set; }
        public DateTime sent { get; set; }
        public bool deleted { get; set; }
        public int sentbyID { get; set; }
        public int CustomerID { get; set; }
        public int StaffID { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
