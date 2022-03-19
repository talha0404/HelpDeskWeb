using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Entities
{
    public class Users : Entity
    {
        public Nullable<long> FirmId { get; set; }       
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LongName { get; set; }
        public string EMail { get; set; }
        public Nullable<int> UserType { get; set; }
        public Nullable<long> CategoryId { get; set; }
        public Nullable<bool> FirmUniq { get; set; }
    }
}
