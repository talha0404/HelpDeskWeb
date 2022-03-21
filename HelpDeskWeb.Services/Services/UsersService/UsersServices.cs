using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpDeskWeb.Domain.Entities;
using HelpDeskWeb.EFCore;
using HelpDeskWeb.Services.BaseServices;

namespace HelpDeskWeb.Services.Services.UsersService
{
    public class UsersServices : BaseService<Users>,IUsersServices
    {
        private readonly HelpDeskWebDbContext _helpDeskWebDbContext;

        public UsersServices(HelpDeskWebDbContext helpDeskWebDbContext) : base(helpDeskWebDbContext)
        {
            _helpDeskWebDbContext = helpDeskWebDbContext;
        }
    }
}
