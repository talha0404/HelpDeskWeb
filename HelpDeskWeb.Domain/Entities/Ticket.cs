using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Entities
{
    public class Ticket : Entity
    {
        public Nullable<int> EffortDay { get; set; }
        public Nullable<int> EffortHour { get; set; }
        public Nullable<int> EffortMinute { get; set; }
        public Nullable<System.DateTime> FinishDate { get; set; }
        public string RefNo { get; set; }
        public Nullable<int> RecordNumber { get; set; }
        public string RecordBy { get; set; }
        public string HeaderDesc { get; set; }
        public string DetailDesc { get; set; }

        public Nullable<long> FirmId { get; set; }//Firma Idsi seçilecek. Kullanıcıya göre eklenecek
        public virtual Firm Firm { get; set; }

        public Nullable<long> TicketTypeId { get; set; }
        public virtual TicketType TicketType { get; set; }

        public Nullable<long> CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Nullable<long> PriorityId { get; set; }
        public virtual Priority Priority { get; set; }

        public Nullable<long> StatusID { get; set; }
        public string AssignUserName { get; set; }
        public Nullable<System.DateTime> AssignDate { get; set; }
        public Nullable<System.DateTime> ComplateDate { get; set; }
        public string CloseUserName { get; set; }
        public Nullable<System.DateTime> CloseDate { get; set; }
        public string CloseDesc { get; set; }
        public string EffectedUser { get; set; }
    }
}
