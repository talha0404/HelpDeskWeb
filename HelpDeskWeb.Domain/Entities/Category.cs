using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Entities
{
    public class Category : Entity
    {
        public Nullable<long> FirmId { get; set; }
        public virtual Firm Fleet { get; set; }
        public string CategoryDesc { get; set; }
    }
}
