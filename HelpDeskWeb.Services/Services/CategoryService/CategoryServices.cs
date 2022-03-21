using HelpDeskWeb.Domain.Entities;
using HelpDeskWeb.EFCore;
using HelpDeskWeb.Services.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.Services.Services.CategoryService
{
    public class CategoryServices : BaseService<Category>, ICategoryServices
    {
        private readonly HelpDeskWebDbContext _helpDeskWebDbContext;

        public CategoryServices(HelpDeskWebDbContext helpDeskWebDbContext) : base(helpDeskWebDbContext)
        {
            _helpDeskWebDbContext = helpDeskWebDbContext;
        }
    }
}
