using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Entities
{
    public class Status : Entity
    {
        public string StatusDesc { get; set; }
    }
}
