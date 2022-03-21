using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskWeb.Domain.Entities;
using HelpDeskWeb.EFCore;
using HelpDeskWeb.Services.BaseServices;

namespace HelpDeskWeb.Services.Services.TicketService
{
    public class TicketServices : BaseService<TicketType>, ITicketServices
    {
        private readonly HelpDeskWebDbContext _helpDeskWebDbContext;

        public TicketServices(HelpDeskWebDbContext helpDeskWebDbContext) : base(helpDeskWebDbContext)
        {
            _helpDeskWebDbContext = helpDeskWebDbContext;
        }
    }
}
