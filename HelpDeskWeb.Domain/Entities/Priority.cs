using HelpDeskWeb.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Domain.Entities
{
    public class Priority : Entity
    {
        public string PriorityDesc { get; set; }
        public string Desc { get; set; }
        public int? Order { get; set; } //Sıra
    }
}
