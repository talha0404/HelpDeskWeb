using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskWeb.Domain.Entities;
using HelpDeskWeb.EFCore;
using HelpDeskWeb.Services.BaseServices;

namespace HelpDeskWeb.Services.Services.TicketHistoryService
{
    public class TicketHistoryServices : BaseService<TicketHistory>, ITicketHistoryServices
    {
        private readonly HelpDeskWebDbContext _helpDeskWebDbContext;

        public TicketHistoryServices(HelpDeskWebDbContext helpDeskWebDbContext) : base(helpDeskWebDbContext)
        {
            _helpDeskWebDbContext = helpDeskWebDbContext;
        }
    }
}
