using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Entities
{
    public class TicketHistory : Entity
    {
        public Nullable<long> TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }

        public Nullable<long> StatusId { get; set; }
        public string UserName { get; set; }
        public string HistoryDesc { get; set; }
        public string IP { get; set; }
    }
}
