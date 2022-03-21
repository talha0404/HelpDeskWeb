using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskWeb.Domain.Entities;
using HelpDeskWeb.EFCore;
using HelpDeskWeb.Services.BaseServices;

namespace HelpDeskWeb.Services.Services.FirmService
{
    public class FirmServices : BaseService<Firm>,IFirmServices
    {
        private readonly HelpDeskWebDbContext _helpDeskWebDbContext;

        public FirmServices(HelpDeskWebDbContext helpDeskWebDbContext) : base(helpDeskWebDbContext)
        {
            _helpDeskWebDbContext = helpDeskWebDbContext;
        }
    }
}
