using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskWeb.Domain.Entities;
using HelpDeskWeb.EFCore;
using HelpDeskWeb.Services.BaseServices;

namespace HelpDeskWeb.Services.Services.StatusService
{
    public class StatusServices : BaseService<Status>, IStatusServices
    {
        private readonly HelpDeskWebDbContext _helpDeskWebDbContext;

        public StatusServices(HelpDeskWebDbContext helpDeskWebDbContext) : base(helpDeskWebDbContext)
        {
            _helpDeskWebDbContext = helpDeskWebDbContext;
        }
    }
}
