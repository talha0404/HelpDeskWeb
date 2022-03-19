using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Entities
{
    public class TicketType : Entity
    {      
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
    }
}
